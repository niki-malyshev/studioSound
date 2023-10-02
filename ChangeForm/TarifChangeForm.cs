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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudioSound.ChangeForm
{
    public partial class TarifChangeForm : Form
    {
        SqlConnection myConn;
        string idTarif;
        string Name;
        string Other;
        string Cost;

        public TarifChangeForm(SqlConnection myConn,
                                string idTarif,
                                string Name,
                                string Other,
                                string Cost)
        {
            InitializeComponent();
            this.myConn = myConn;
            this.idTarif = idTarif;
            this.Name = Name;
            this.Other = Other;
            this.Cost = Cost;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                txtName.Enabled = true;
                txtOther.Enabled = true;
                txtPrice.Enabled = true;
            }
            else
            {
                btnChangeWorker.Enabled = false;
                txtName.Enabled = false;
                txtOther.Enabled = false;
                txtPrice.Enabled = false;
            }

        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateTarifData] " +
            "@EmployeeId= @p0, " +
            "@name= @p1, " +
            "@other = @p2, " +
            "@cost=@p3",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 50);
            myComm.Parameters["@p0"].Value = textBox1.Text.ToString();
            myComm.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            myComm.Parameters["@p1"].Value = txtName.Text.ToString();
            myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p2"].Value = txtOther.Text.ToString();
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = txtPrice.Text.ToString();
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Тариф успешно обновлен в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TarifChangeForm_Load(object sender, EventArgs e)
        {
            loadData1();
            textBox1.Text = idTarif;
            txtName.Text = Name;
            txtOther.Text = Other;
            txtPrice.Text = Cost;

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData1()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM ContractView Where Тариф LIKE '%" + Name + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }
    }
}
