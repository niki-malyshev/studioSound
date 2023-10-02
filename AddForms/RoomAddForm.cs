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
    public partial class RoomAddForm : Form
    {
        SqlConnection myConn;
        public RoomAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_room] " +
            "@other = @p1",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p1", SqlDbType.VarChar, 200);
            myComm.Parameters["@p1"].Value = txtOtherRoom.Text.ToString();
            MessageBox.Show("Помещение успешно добавлено в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
