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

namespace StudioSound.AddForms
{
    public partial class ClientAddForm : Form
    {
        SqlConnection myConn;
        public ClientAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }
        int indexBlackList;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_client] " +
            "@pasport= @p1, " +
            "@fio = @p2, " +
            "@mobile=@p3," +
            "@black_list= @p4, " +
            "@email = @p5",
            myConn);

            //Создать параметр и передать в него значение текстового поля
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

            
            MessageBox.Show("Клиент успешно добавлен в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBlackL_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBlackList = cmbBlackL.SelectedIndex;
        }
    }
}
