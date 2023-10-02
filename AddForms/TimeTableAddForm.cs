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
    public partial class TimeTableAddForm : Form
    {
        SqlConnection myConn;
        public TimeTableAddForm(SqlConnection myConn)
        {
            InitializeComponent();
            this.myConn = myConn;
        }

        int indexWorker;
        int indexRoom;
        int indexContract;

        private void TimeTableAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            //Создать команду для добавления
            SqlCommand myComm = new SqlCommand("Exec [dbo].[add_timetable] " +
            "@date= @p1, " +
            "@worker = @p2, " +
            "@room=@p3," +
            "@contract= @p4, " +
            "@time = @p5",
            myConn);

            //Создать параметр и передать в него значение текстового поля
            myComm.Parameters.Add("@p1", SqlDbType.NVarChar, 10);
            myComm.Parameters["@p1"].Value = dateContract.Value.ToShortDateString();
            myComm.Parameters.Add("@p2", SqlDbType.Int, 100);
            myComm.Parameters["@p2"].Value = indexWorker;
            myComm.Parameters.Add("@p3", SqlDbType.Int, 100);
            myComm.Parameters["@p3"].Value = indexRoom;
            myComm.Parameters.Add("@p4", SqlDbType.Int, 100);
            myComm.Parameters["@p4"].Value = indexContract;
            myComm.Parameters.Add("@p5", SqlDbType.Int, 100);
            myComm.Parameters["@p5"].Value = txtHoursWork.Text.ToString();
            //вызвать процедуру без возвращения результата
            myComm.ExecuteNonQuery();
            MessageBox.Show("Расписание успешно добавлено в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexWorker = int.Parse(cmbWorker.SelectedValue.ToString());
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexRoom = int.Parse(cmbRoom.SelectedValue.ToString());
        }

        private void cmbContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexContract = int.Parse(cmbContract.SelectedValue.ToString());
        }
    }
}
