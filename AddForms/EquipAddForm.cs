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
using System.Xml.Linq;

namespace StudioSound.AddForms
{
    public partial class EquipAddForm : Form
    {
        SqlConnection myConn;
        public EquipAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }

        int indexRoom;
        int indexDefect;

        private void EquipAddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studio_soundDataSet.Помещение". При необходимости она может быть перемещена или удалена.
            this.помещениеTableAdapter.Fill(this.studio_soundDataSet.Помещение);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_equip] " +
            "@room= @p1, " +
            "@name = @p2, " +
            "@status =@p3," +
            "@other = @p4",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p1", SqlDbType.Int, 150);
            myComm.Parameters["@p1"].Value = indexRoom;
            myComm.Parameters.Add("@p2", SqlDbType.VarChar, 100);
            myComm.Parameters["@p2"].Value = txtName.Text.ToString();
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = indexDefect;
            myComm.Parameters.Add("@p4", SqlDbType.VarChar, 100);
            myComm.Parameters["@p4"].Value = txtOther.Text.ToString();

            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Оборудование успешно добавлено в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
        }

        private void cmbCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexDefect = cmbCheck.SelectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
