using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioSound.ChangeForm
{
    public partial class TimeTableAddForm1 : Form
    {
        SqlConnection myConn;
        public TimeTableAddForm1(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }

        int indexWorker;
        int indexRoom;
        int indexContract;
        string valueRoom;

        private void TimeTableAddForm1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.ContractView". При необходимости она может быть перемещена или удалена.
            this.contractViewTableAdapter.Fill(this.studio_soundDataSet.ContractView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.studio_soundDataSet.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Помещение". При необходимости она может быть перемещена или удалена.
            this.помещениеTableAdapter.Fill(this.studio_soundDataSet.Помещение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.studio_soundDataSet.Сотрудники);

        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_timetable] " +
            "@date= @p1, " +
            "@worker = @p2, " +
            "@room=@p3," +
            "@contract= @p4, " +
            "@time = @p5",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p1"].Value = dateContract.Value.ToShortDateString();
            myComm.Parameters.Add("@p2", SqlDbType.Int, 100);
            myComm.Parameters["@p2"].Value = indexWorker;
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = indexRoom;
            myComm.Parameters.Add("@p4", SqlDbType.Int, 100);
            myComm.Parameters["@p4"].Value = indexContract;
            myComm.Parameters.Add("@p5", SqlDbType.Int, 100);
            myComm.Parameters["@p5"].Value = txtHoursWork.Text.ToString();
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Договор успешно добавлено в расписание!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
            valueRoom = cmbRoom.SelectedValue.ToString();
            loadData2();
        }

        private void cmbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexContract = int.Parse(cmbContract.SelectedValue.ToString());
            //dataGridView1.Rows.Clear();
            loadData1();
            loadData3();
        }


        private void loadData1()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM [ContractView]" /*Where [Номер договора] = " + indexContract*/;

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }

        private void loadData3()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM [TimeTableView] Where Договор = " + indexContract;

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

        }

        private void loadData2()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM [TimeTableView] Where Помещение  LIKE '%" + valueRoom + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

        }
    }
}
