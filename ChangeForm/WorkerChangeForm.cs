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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudioSound.ChangeForm
{
    public partial class WorkerChangeForm : Form
    {
        SqlConnection myConn;
        string idWorker;
        string FIO;
        string Email;
        string Post;
        string Pasport;
        string Phone;
        string Theme;
        string Leader;

        int indexLeader;


        public WorkerChangeForm(SqlConnection myConn,
                                string idWorker,
                                string FIO,
                                string Email,
                                string Post,
                                string Pasport,
                                string Phone,
                                string Theme,
                                string Leader)
        {
            InitializeComponent();
            this.myConn= myConn;
            this.idWorker = idWorker;
            this.FIO = FIO;
            this.Email = Email;
            this.Post = Post;
            this.Pasport = Pasport;
            this.Phone = Phone;
            this.Theme = Theme;
            this.Leader = Leader;
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateWorkerData] " +
            "@EmployeeId= @p0, " +
            "@NewFIO= @p1, " +
            "@NewEmail = @p2, " +
            "@NewPost=@p3," +
            "@NewPassport= @p4, " +
            "@NewPhone = @p5, " +
            "@NewWorkTheme= @p6, " +
            "@NewLeader = @p7",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 150);
            myComm.Parameters["@p0"].Value = txtIdWorker.Text.ToString();
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 150);
            myComm.Parameters["@p1"].Value = txtNameWorker.Text.ToString();
            myComm.Parameters.Add("@p2", SqlDbType.VarChar, 100);
            myComm.Parameters["@p2"].Value = txtEmailWorker.Text.ToString();
            myComm.Parameters.Add("@p3", SqlDbType.VarChar, 100);
            myComm.Parameters["@p3"].Value = txtPost.Text.ToString();
            myComm.Parameters.Add("@p4", SqlDbType.NChar, 6);
            myComm.Parameters["@p4"].Value = txtPasport.Text.ToString();
            myComm.Parameters.Add("@p5", SqlDbType.NChar, 11);
            myComm.Parameters["@p5"].Value = txtPhone.Text.ToString();
            myComm.Parameters.Add("@p6", SqlDbType.NVarChar, 150);
            myComm.Parameters["@p6"].Value = txtThemeWorker.Text.ToString();
            myComm.Parameters.Add("@p7", SqlDbType.Int, 50);
            myComm.Parameters["@p7"].Value = indexLeader;
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Сотрудник успешно изменен в базе!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WorkerChangeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Раписание". При необходимости она может быть перемещена или удалена.
            this.раписаниеTableAdapter.Fill(this.studio_soundDataSet.Раписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.studio_soundDataSet.Договор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.studio_soundDataSet.Сотрудники);
            txtIdWorker.Text = idWorker;
            txtNameWorker.Text = FIO;
            txtEmailWorker.Text = Email;
            txtPost.Text = Post;
            txtPasport.Text = Pasport;
            txtPhone.Text = Phone;
            txtThemeWorker.Text = Theme;
            cmbLeader.Text = Leader;
            //Запускаем процедуру выборки данных
            loadData1();
            loadData2();

            indexLeader = int.Parse(cmbLeader.SelectedValue.ToString());

        }
        private void loadData1()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            string query = "SELECT * FROM ContractView Where Сотрудник LIKE '%" + FIO + "%'";

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

            string query = "SELECT * FROM [TimeTableView] Where Сотрудник LIKE '%" + FIO + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

        }

        private void cmbLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexLeader = int.Parse(cmbLeader.SelectedValue.ToString());

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnChangeWorker.Enabled = true;
                txtNameWorker.Enabled = true;
                txtEmailWorker.Enabled = true;
                txtPost.Enabled = true;
                txtPasport.Enabled = true;
                txtPhone.Enabled = true;
                txtThemeWorker.Enabled = true;
                cmbLeader.Enabled = true;
            }
            else
            {
                btnChangeWorker.Enabled = false;
                txtNameWorker.Enabled = false;
                txtEmailWorker.Enabled = false;
                txtPost.Enabled = false;
                txtPasport.Enabled = false;
                txtPhone.Enabled = false;
                txtThemeWorker.Enabled = false;
                cmbLeader.Enabled = false;
            }
        }
    }
}
