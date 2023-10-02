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
using System.Xml;
using System.Collections;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection;

namespace StudioSound.AddForms
{
    
    public partial class WorkerAddForm : Form
    {   // объявление переменной
        SqlConnection myConn;
        // объявление конструктора с параметром

        public WorkerAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            // задание значения параметру
            this.myConn = myConn;
           
        }
        int indexLeader;

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_worker] " +
            "@fio= @p1, " +
            "@email = @p2, " +
            "@post=@p3," +
            "@pasport= @p4, " +
            "@mobile = @p5, " +
            "@theme_work= @p6, " +
            "@leader = @p7", 
            myConn);

            //Создать параметр и передать в него значение текстового поля
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
            MessageBox.Show("Сотрудник успешно добавлен в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();

        }

        private void WorkerAddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.studio_soundDataSet.Сотрудники);
        }

        private void cmbLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexLeader = int.Parse(cmbLeader.SelectedValue.ToString());
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

    
}



