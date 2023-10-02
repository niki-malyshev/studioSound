using StudioSound.AddForms;
using StudioSound.ChangeForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioSound
{
    public partial class WorkerListForm : Form
    {

        SqlConnection myConn = new SqlConnection();
        int indexSelectRow;
        int SelectedTable = 0;
        public WorkerListForm()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = Color.Gray;
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.WorkersView". При необходимости она может быть перемещена или удалена.
            //this.workersViewTableAdapter.Fill(this.studio_soundDataSet.WorkersView);
            ////Получаем строку подключения из параметров
            //string StrConn = Properties.Settings.Default.ConnStr.ToString();
            ////Создаем подключение
            //myConn.ConnectionString = StrConn;
            //myConn.Open();
            ////Запускаем процедуру выборки данных
            //loadData();
            LoadView();
        }
        //private void loadData()
        //{
        //    switch (SelectedTable)
        //    {
        //        case 0:
        //            {
        //                //Создаем команду для выборки данных
        //                SqlCommand myComm = new SqlCommand("SELECT * FROM WorkersView", myConn);
        //                SqlDataReader myReader = myComm.ExecuteReader();
        //                //Заполняем данными
        //                DataTable dt = new DataTable();
        //                dt.Load(myReader);
        //                dataGridView1.AutoGenerateColumns = false;
        //                dataGridView1.DataSource = dt;
        //                dataGridView1.Refresh();
        //                break;
        //            }
        //        case 1:
        //            {
        //                //Создаем команду для выборки данных
        //                SqlCommand myComm = new SqlCommand("SELECT * FROM Помещение", myConn);
        //                SqlDataReader myReader = myComm.ExecuteReader();
        //                //Заполняем данными
        //                DataTable dt = new DataTable();
        //                dt.Load(myReader);
        //                dataGridView1.AutoGenerateColumns = false;
        //                dataGridView1.DataSource = dt;
        //                dataGridView1.Refresh();
        //                break;
        //            }
        //    }

        //}

        private void Form2_FormClosing(object sender,FormClosingEventArgs e)
        {
            myConn.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (SelectedTable)
            {
                case 0:
                    {
                        //DialogResult result = MessageBox.Show("Будет удалена вся " + "информация о сотруднике. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
                        //if (result == DialogResult.Yes)
                        //{
                        //    //Создать команду для удаления
                        //    SqlCommand myComm = new SqlCommand("delete Сотрудники where idСотрудники = " + "@p1", myConn);
                        //    //Создать параметр и передать в него
                        //    //значение текстового поля
                        //    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
                        //    DataGridViewRow SelectedRow = dataGridView1.Rows[indexSelectRow];
                        //    myComm.Parameters["@p1"].Value = SelectedRow.Cells[0].Value.ToString();
                        //    //Выполнить запрос на удаление без возвращения результата
                        //    myComm.ExecuteNonQuery();
                        //    //обновить таблицу на форме
                        //    LoadView();
                        //}
                        break;
                    }
                case 1:
                    {
                        //DialogResult result = MessageBox.Show("Будет удалена вся " + "информация о помещение. Продолжить?", "Внимание!", MessageBoxButtons.YesNo);
                        //if (result == DialogResult.Yes)
                        //{
                        //    //Создать команду для удаления
                        //    SqlCommand myComm = new SqlCommand("DELETE FROM Оборудование WHERE Помещение_idПомещение IN (SELECT idПомещение FROM Помещение WHERE idПомещение =" + "@p1" + ")" +
                        //        "DELETE FROM Помещение WHERE idПомещение =" + "@p1", myConn);
                        //    //Создать параметр и передать в него
                        //    //значение текстового поля
                        //    myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
                        //    DataGridViewRow SelectedRow = dataGridView1.Rows[indexSelectRow];
                        //    myComm.Parameters["@p1"].Value = SelectedRow.Cells[0].Value.ToString();
                        //    //Выполнить запрос на удаление без возвращения результата
                        //    myComm.ExecuteNonQuery();
                        //    //обновить таблицу на форме
                        //    LoadView();
                        //}
                        break;
                    }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectRow = e.RowIndex;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
 
            switch (SelectedTable)
            {
                case 0:
                    {
                        WorkerAddForm frm_add_worker = new WorkerAddForm(myConn);
                        frm_add_worker.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        ContractAddForm frm_add_contract= new ContractAddForm(myConn);
                        frm_add_contract.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        ClientAddForm frm_add_client = new ClientAddForm(myConn);
                        frm_add_client.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        TarifAddForm frm_add_tarif = new TarifAddForm(myConn);
                        frm_add_tarif.ShowDialog();
                        break;
                    }
                case 4:
                    {
                        RoomAddForm frm_add_room = new RoomAddForm(myConn);
                        frm_add_room.ShowDialog();
                        break;
                    }
                case 5:
                    {
                        EquipAddForm frm_add_equip = new EquipAddForm(myConn);
                        frm_add_equip.ShowDialog();
                        break;
                    }
                case 6:
                    {
                        TimeTableAddForm1 frm_add_timetable = new TimeTableAddForm1(myConn);
                        frm_add_timetable.ShowDialog();
                        break;
                    }
            }

            LoadView();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           DataGridViewRow SelectedRow = dataGridView1.Rows[indexSelectRow];
            //Открытие формы с данными

            switch (SelectedTable)
            {
                case 0:
                    {
                        WorkerChangeForm frm3 = new WorkerChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[4].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[5].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[6].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[7].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();
                        break;
                    }
                case 1:
                    {
                        ContractChangeForm frm3 = new ContractChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    DateTime.Parse(dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString()),
                                    DateTime.Parse(dataGridView1.Rows[indexSelectRow].Cells[4].Value.ToString()),
                                    DateTime.Parse(dataGridView1.Rows[indexSelectRow].Cells[5].Value.ToString()),
                                    dataGridView1.Rows[indexSelectRow].Cells[6].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[9].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[8].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
                case 2:
                    {
                        ClientChangeForm frm3 = new ClientChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[4].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[5].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
                case 3:
                    {
                        TarifChangeForm frm3 = new TarifChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
                case 4:
                    {
                        RoomChangeForm frm3 = new RoomChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),                                    
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
                case 5:
                    {
                        EquipChangeForm frm3 = new EquipChangeForm(myConn,
                                    dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[4].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
                case 6:
                    {
                        TimeTableChangeForm frm3 = new TimeTableChangeForm(myConn,
                                    DateTime.Parse(dataGridView1.Rows[indexSelectRow].Cells[0].Value.ToString()),
                                    dataGridView1.Rows[indexSelectRow].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[2].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[3].Value.ToString(),
                                    dataGridView1.Rows[indexSelectRow].Cells[4].Value.ToString());
                        frm3.ShowDialog();
                        LoadView();

                        break;
                    }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //string searchString = SearchWorkers + toolStripTextBox1.Text + "%'";
            switch (SelectedTable)
            {
                case 0:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchWorkers] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        // Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 1:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchContract] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 2:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchClient] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 3:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchTarif]" + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 4:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchRooms] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 5:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchEquip] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
                case 6:
                    {
                        LoadView();
                        SqlCommand myComm = new SqlCommand("Exec [dbo].[SearchTimeTable] " + "@searchText= @p1", myConn);
                        myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 100);
                        myComm.Parameters["@p1"].Value = tsTxtSearch.Text.ToString();
                        SqlDataReader myReader = myComm.ExecuteReader();
                        //Заполняем данными
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        myReader.Close();
                        break;
                    }
            }
        }

        private void LoadView()
        {
            string StrConn = Properties.Settings.Default.ConnStr.ToString();

            if (myConn.State != ConnectionState.Open)
            {
                myConn.ConnectionString = StrConn;
                myConn.Open();
            }


            switch (SelectedTable)
            {
                case 0:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM WorkersView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;

                    }
                case 1:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM ContractView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM ClientsView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;

                    }
                case 3:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM TarifView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM RoomView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;

                    }
                case 5:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM EquipView";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            //myConn.ConnectionString = StrConn;
                            //myConn.Open();

                            string query = "SELECT * FROM [TimeTableView]";

                            SqlDataAdapter adapter = new SqlDataAdapter(query, myConn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message);
                        }
                        break;
                    }

            }
            
        }
        private void WorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Clear();
            SelectedTable = 0;
            myConn.Close();
            LoadView();
        }

        private void ContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Clear();
            SelectedTable = 1;
            myConn.Close();
            LoadView();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Clear();
            SelectedTable = 2;
            myConn.Close();
            LoadView();
        }

        private void tarifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Clear();
            SelectedTable = 3;
            myConn.Close();
            LoadView();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Clear();
            SelectedTable = 4;
            myConn.Close();
            LoadView();
        }

        private void equipToolStripMenuItem_Click(object sender, EventArgs e)
        {tsTxtSearch.Clear();
            SelectedTable = 5;
            myConn.Close();
            LoadView();
        }

        private void TimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {tsTxtSearch.Clear();
            SelectedTable = 6;
            myConn.Close();
            LoadView();
        }
    }
}
