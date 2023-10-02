using StudioSound.AddForms;
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
    public partial class ContractChangeForm : Form
    {
        SqlConnection myConn;
        string idContract;
        string Client;
        string Worker;
        DateTime DateContract;
        DateTime DateS;
        DateTime DateE;
        string Time;
        string Theme;
        string Tarif;

        int indexClient;
        int indexWorker;
        int indexTarif;

        public ContractChangeForm(SqlConnection myConn,
                                    string idContract,
                                    string Client,
                                    string Worker,
                                    DateTime DateContract,
                                    DateTime DateS,
                                    DateTime DateE,
                                    string Time,
                                    string Theme,
                                    string Tarif)
        {
            InitializeComponent();

            this.myConn = myConn;
            this.idContract = idContract;
            this.Client = Client;
            this.Worker = Worker;
            this.DateContract = DateContract;
            this.DateS = DateS;
            this.DateE = DateE;
            this.Time = Time;
            this.Theme = Theme;
            this.Tarif = Tarif;

        }

        private void ContractChangeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.studio_soundDataSet.Тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.studio_soundDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.studio_soundDataSet.Клиенты);
            FillComboBoxFromDatabase();
            textBox1.Text = idContract;
            cmbClient.Text = Client;
            cmbWorker.Text = Worker;
            dateContract.Value = DateContract;
            dateStart.Value = DateS;
            dateEnd.Value = DateE;
            txtHoursWork.Text = Time;
            txtTheme.Text = Theme;
            cmbTarif.Text = Tarif;
            loadData1();

            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
            indexTarif = int.Parse(cmbTarif.SelectedValue.ToString());

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientAddForm frm_add_client = new ClientAddForm(myConn);
            frm_add_client.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbClient.Items.Clear();
            FillComboBoxFromDatabase();
            cmbClient.Refresh();
        }

        private void btnChangeWorker_Click(object sender, EventArgs e)
        {
            SqlCommand myComm = new SqlCommand("Exec [dbo].[UpdateContractData] " +
            "@EmployeeId= @p0, " +
            "@NEWclient= @p1, " +
            "@NEWworker = @p2, " +
            "@NEWdate=@p3," +
            "@NEWdateS= @p4, " +
            "@NEWdateE = @p5, " +
            "@NEWtime= @p6, " +
            "@NEWtheme = @p7," +
            "@NEWtarif = @p8",
            myConn);


            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p0", SqlDbType.Int, 150);
            myComm.Parameters["@p0"].Value = textBox1.Text.ToString();
            myComm.Parameters.Add("@p1", SqlDbType.Int, 50);
            myComm.Parameters["@p1"].Value = indexClient;
            myComm.Parameters.Add("@p2", SqlDbType.Int, 50);
            myComm.Parameters["@p2"].Value = indexWorker;
            myComm.Parameters.Add("@p3", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p3"].Value = dateContract.Value.ToShortDateString();
            myComm.Parameters.Add("@p4", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p4"].Value = dateStart.Value.ToShortDateString();
            myComm.Parameters.Add("@p5", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p5"].Value = dateEnd.Value.ToShortDateString();
            myComm.Parameters.Add("@p6", SqlDbType.Int, 150);
            myComm.Parameters["@p6"].Value = txtHoursWork.Text.ToString();
            myComm.Parameters.Add("@p7", SqlDbType.VarChar, 150);
            myComm.Parameters["@p7"].Value = txtTheme.Text.ToString();
            myComm.Parameters.Add("@p8", SqlDbType.Int, 50);
            myComm.Parameters["@p8"].Value = indexTarif;
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Договор успешно добавлен в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnAddClient.Enabled = true;
                button1.Enabled = true;
                cmbClient.Enabled = true;
                cmbWorker.Enabled = true;
                cmbTarif.Enabled = true;
                txtHoursWork.Enabled = true;
                txtTheme.Enabled = true;
                dateContract.Enabled = true;
                dateStart.Enabled = true;
                dateEnd.Enabled = true;

            }
            else
            {
                btnChangeWorker.Enabled = false;
                btnAddClient.Enabled = false;
                button1.Enabled = false;
                cmbClient.Enabled = false;
                cmbWorker.Enabled = false;
                cmbTarif.Enabled = false;
                txtHoursWork.Enabled = false;
                txtTheme.Enabled = false;
                dateContract.Enabled = false;
                dateStart.Enabled = false;
                dateEnd.Enabled = false;
            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //indexClient = int.Parse(cmbClient.SelectedValue.ToString());
            //int fff = 1;
            KeyValuePair<string, int> selectedClient = (KeyValuePair<string, int>)cmbClient.SelectedItem;
            indexClient = selectedClient.Value;
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
        }

        private void cmbTarif_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTarif = int.Parse(cmbTarif.SelectedValue.ToString());
        }

        private void FillComboBoxFromDatabase()
        {
            // Запрос для выборки данных из базы данных
            string query = "SELECT id_client, ФИО FROM Клиенты";

            // Создание команды для выполнения запроса
            SqlCommand command = new SqlCommand(query, myConn);

            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }

            try
            {
                // Создание ридера данных для чтения результатов запроса
                SqlDataReader reader = command.ExecuteReader();

                // Очистка списка элементов ComboBox
                cmbClient.Items.Clear();

                // Чтение данных и добавление их в ComboBox
                while (reader.Read())
                {
                    int id_client = reader.GetInt32(0);
                    string fio = reader.GetString(1);
                    cmbClient.Items.Add(new KeyValuePair<string, int>(fio, id_client));
                }

                // Закрытие ридера данных
                reader.Close();
            }
            catch (Exception ex)
            {
                // Обработка ошибок при выполнении запроса
                MessageBox.Show("Ошибка: " + ex.Message);
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

            string query = "SELECT * FROM [TimeTableView] Where Договор = " + idContract;

            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }




    }
}
