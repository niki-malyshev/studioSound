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
    public partial class TarifAddForm : Form
    {
        SqlConnection myConn;
        public TarifAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_tarif] " +
            "@name= @p1, " +
            "@other = @p2, " +
            "@cost=@p3",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            myComm.Parameters["@p1"].Value = txtName.Text.ToString();
            myComm.Parameters.Add("@p2", SqlDbType.NVarChar, 100);
            myComm.Parameters["@p2"].Value = txtOther.Text.ToString();
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = txtPrice.Text.ToString();
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Сотрудник успешно добавлен в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
