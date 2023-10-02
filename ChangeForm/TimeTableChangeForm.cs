using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StudioSound.ChangeForm
{
    public partial class TimeTableChangeForm : Form
    {
        SqlConnection myConn;
        DateTime DateCon;
        string worker;
        string room;
        string contract;
        string time;

        public TimeTableChangeForm(SqlConnection myConn,
                                    DateTime DateCon,
                                    string worker,
                                    string room,
                                    string contract,
                                    string time)
        {
            InitializeComponent();
            this.myConn = myConn;
            this.DateCon = DateCon;
            this.worker = worker;
            this.room = room;
            this.contract = contract;
            this.time = time;
        }

        int indexWorker;
        int indexRoom;
        int indexContract;

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateTimeTableData] " +
            "@date= @p0, " +
            "@NEWdate= @p1, " +
            "@worker = @p2, " +
            "@room=@p3," +
            "@contract= @p4, " +
            "@time = @p5",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p0"].Value = dateTimePicker1.Value.ToShortDateString();
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
            MessageBox.Show("Расписание успешно изменено в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                cmbContract.Enabled = true;
                cmbWorker.Enabled = true;
                cmbRoom.Enabled = true;
                txtHoursWork.Enabled = true;
                dateContract.Enabled = true;

            }
            else
            {
                btnChangeWorker.Enabled = false;
                cmbContract.Enabled = false;
                cmbWorker.Enabled = false;
                cmbRoom.Enabled = false;
                txtHoursWork.Enabled = false;
                dateContract.Enabled = false;
            }
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
        }

        private void cmbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexContract = int.Parse(cmbContract.SelectedValue.ToString());
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeTableChangeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.ContractView". При необходимости она может быть перемещена или удалена.
            this.contractViewTableAdapter.Fill(this.studio_soundDataSet.ContractView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.studio_soundDataSet.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Помещение". При необходимости она может быть перемещена или удалена.
            this.помещениеTableAdapter.Fill(this.studio_soundDataSet.Помещение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.studio_soundDataSet.Сотрудники);
            dateTimePicker1.Value = DateCon;
            cmbContract.Text = contract;
            cmbWorker.Text = worker;
            cmbRoom.Text = room;
            txtHoursWork.Text = time;
            dateContract.Value = DateCon;

            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
            indexContract = int.Parse(cmbContract.SelectedValue.ToString());
        }
    }
}
