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

    public partial class ClientChangeForm : Form
    {

        SqlConnection myConn;
        string idClient;
        string Pasport;
        string FIO;
        string mobile;
        string black_list;
        string email;

        public ClientChangeForm(SqlConnection myConn,
                                string idClient,
                                string Pasport,
                                string FIO,
                                string mobile,
                                string black_list,
                                string email)
        {
            InitializeComponent();
            this.myConn = myConn;
            this.idClient = idClient;
            this.Pasport = Pasport;
            this.FIO = FIO;
            this.mobile = mobile;
            this.black_list = black_list;
            this.email = email;

        }

        int indexBlackList;

        private void ClientChangeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = idClient;
            txtFIO.Text = FIO;
            txtPasport.Text = Pasport;
            txtPhone.Text = mobile;
            txtEmail.Text = email;
            cmbBlackL.Text = black_list;
            loadData1();
            indexBlackList = cmbBlackL.SelectedIndex;
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {

            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateClientData] " +
            "@EmployeeId= @p0, " +
            "@NEWpasport= @p1, " +
            "@NEWfio = @p2, " +
            "@NEWmobile=@p3," +
            "@NEWblack_list= @p4, " +
            "@email = @p5",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 6);
            myComm.Parameters["@p0"].Value = textBox1.Text.ToString();

            myComm.Parameters.Add("@p1", SqlDbType.NChar, 6);
            myComm.Parameters["@p1"].Value = txtPasport.Text.ToString();

            myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 150);
            myComm.Parameters["@p2"].Value = txtFIO.Text.ToString();

            myComm.Parameters.Add("@p3", SqlDbType.NChar, 11);
            myComm.Parameters["@p3"].Value = txtPhone.Text.ToString();

            myComm.Parameters.Add("@p4", SqlDbType.Int, 100);
            myComm.Parameters["@p4"].Value = indexBlackList;

            myComm.Parameters.Add("@p5", SqlDbType.VarChar, 100);
            myComm.Parameters["@p5"].Value = txtEmail.Text.ToString();


            
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Клиент успешно обновлен в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBlackL_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBlackList = cmbBlackL.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                txtEmail.Enabled = true;
                txtFIO.Enabled = true;
                txtPasport.Enabled = true;
                txtPhone.Enabled = true;
                cmbBlackL.Enabled = true;
            }
            else
            {
                btnChangeWorker.Enabled = false;
                txtEmail.Enabled = false;
                txtFIO.Enabled = false;
                txtPasport.Enabled = false;
                txtPhone.Enabled = false;
                cmbBlackL.Enabled = false;
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

            string query = "SELECT * FROM ContractView Where Клиент LIKE '%" + FIO + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }


    }
}
