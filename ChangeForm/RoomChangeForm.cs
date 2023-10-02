using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioSound.ChangeForm
{
    public partial class RoomChangeForm : Form
    {
        SqlConnection myConn;
        string idRoom;
        string other;

        public RoomChangeForm(SqlConnection myConn,
                                string idRoom,
                                string other)
        {
            InitializeComponent();
            this.myConn = myConn;
            this.idRoom = idRoom;
            this.other = other;
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateRoomData] " +
            "@EmployeeId = @p0," +
            "@NEWother = @p1",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 200);
            myComm.Parameters["@p0"].Value = textBox1.Text.ToString();
            myComm.Parameters.Add("@p1", SqlDbType.VarChar, 200);
            myComm.Parameters["@p1"].Value = txtOtherRoom.Text.ToString();
            MessageBox.Show("Помещение успешно обновленое в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();

        }

        private void RoomChangeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = idRoom;
            txtOtherRoom.Text = other;

            loadData1();
            loadData2();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                txtOtherRoom.Enabled = true;
            }
            else
            {
                btnChangeWorker.Enabled = false;
                txtOtherRoom.Enabled = false;
            }
        }

        private void loadData1()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM EquipView Where Помещение  LIKE '%" + other + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }

        private void loadData2()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM [TimeTableView] Where Помещение  LIKE '%" + other + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
