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

namespace StudioSound
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void cmbTypeAutor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTypeAutor.SelectedIndex != 0)
            {
                txtUserName.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtUserName.Enabled = false;
                txtPass.Enabled = false;
            }
        }

        private void bttConnect_Click(object sender, EventArgs e)
        {
            //Формирование строки подключения
            string StrConn;
            if (cmbTypeAutor.SelectedIndex == 0)
            {
                StrConn = "Data Source =" + txtNameSrv.Text +
                ";Initial Catalog =" + txtNameDB.Text +
                ";Integrated Security = True";
            }

            else
            {
                StrConn = "Data Source =" + txtNameSrv.Text +
                ";Initial Catalog =" + txtNameDB.Text +
                ";User ID =" + txtUserName.Text +
                ";Password =" + txtPass.Text;
            }
            //Создание нового подключения на основе строки
            SqlConnection MainConn = new SqlConnection(StrConn);
            //Открытие подключения
            MainConn.Open();
            //Проверка, установлено ли соединение с БД
            if (MainConn.State == ConnectionState.Open)
            {
                //Если подключение прошло успешно,
                //сохраняем строку в параметры
                Properties.Settings.Default.ConnStr = StrConn;
                MainConn.Close();
                //Переходим на следующую форму
                Hide();
                WorkerListForm frm2 = new WorkerListForm();
                frm2.ShowDialog();
                Close();
            }
            else
            {
                //Если подключение не установлено,
                //то выводим сообщение
                MessageBox.Show("Соединение с БД не установлено",
                "Внимание!");
            }
        }
    }
}
