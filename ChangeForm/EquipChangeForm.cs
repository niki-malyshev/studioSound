using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudioSound.ChangeForm
{
    public partial class EquipChangeForm : Form
    {

        SqlConnection myConn;
        string idEquip;
        string room;
        string name;
        string status;
        string other;

        public EquipChangeForm(SqlConnection myConn,
                                string idEquip,
                                string room,
                                string name,
                                string status,
                                string other)
        {
            InitializeComponent();
            this.myConn = myConn;
            this.idEquip = idEquip;
            this.room = room;
            this.name = name;
            this.status = status;
            this.other = other;

        }

        int indexRoom;
        int indexDefect;

        private void EquipChangeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Помещение". При необходимости она может быть перемещена или удалена.
            this.помещениеTableAdapter.Fill(this.studio_soundDataSet.Помещение);
            loadData1();

            textBox1.Text = idEquip;
            txtName.Text = name;
            txtOther.Text = other;
            cmbRoom.Text = room;
            cmbCheck.Text = status;

            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
            indexDefect = cmbCheck.SelectedIndex;
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateEquipData] " +
            "@EmployeeId= @p0, " +
            "@Newroom= @p1, " +
            "@Newname = @p2, " +
            "@Newstatus =@p3," +
            "@Newother = @p4",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 150);
            myComm.Parameters["@p0"].Value = textBox1.Text.ToString();
            myComm.Parameters.Add("@p1", SqlDbType.Int, 150);
            myComm.Parameters["@p1"].Value = indexRoom;
            myComm.Parameters.Add("@p2", SqlDbType.VarChar, 100);
            myComm.Parameters["@p2"].Value = txtName.Text.ToString();
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = indexDefect;
            myComm.Parameters.Add("@p4", SqlDbType.VarChar, 100);
            myComm.Parameters["@p4"].Value = txtOther.Text.ToString();

            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Оборудование успешно обновлено в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                textBox1.Enabled = true;
                txtName.Enabled = true;
                txtOther.Enabled = true;
                cmbCheck.Enabled = true;
                cmbRoom.Enabled = true;
            }
            else
            {
                btnChangeWorker.Enabled = false;
                textBox1.Enabled = false;
                txtName.Enabled = false;
                txtOther.Enabled = false;
                cmbCheck.Enabled = false;
                cmbRoom.Enabled = false;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexDefect = cmbCheck.SelectedIndex;
        }

        private void loadData1()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM EquipView Where Номер = " + idEquip;

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }
    }
}
