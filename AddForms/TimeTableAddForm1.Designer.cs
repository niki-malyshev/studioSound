namespace StudioSound.ChangeForm
{
    partial class TimeTableAddForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.cmbContract = new System.Windows.Forms.ComboBox();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateContract = new System.Windows.Forms.DateTimePicker();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.помещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.помещениеTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ПомещениеTableAdapter();
            this.договорTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ДоговорTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contractViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ContractViewTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(108, 110);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(200, 20);
            this.txtHoursWork.TabIndex = 65;
            // 
            // cmbContract
            // 
            this.cmbContract.DataSource = this.договорBindingSource;
            this.cmbContract.DisplayMember = "idДоговор";
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Location = new System.Drawing.Point(108, 83);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(200, 21);
            this.cmbContract.TabIndex = 64;
            this.cmbContract.ValueMember = "idДоговор";
            this.cmbContract.SelectedIndexChanged += new System.EventHandler(this.cmbContract_SelectedIndexChanged);
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // studio_soundDataSet
            // 
            this.studio_soundDataSet.DataSetName = "Studio_soundDataSet";
            this.studio_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbWorker
            // 
            this.cmbWorker.DataSource = this.сотрудникиBindingSource;
            this.cmbWorker.DisplayMember = "ФИО";
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(108, 29);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 21);
            this.cmbWorker.TabIndex = 63;
            this.cmbWorker.ValueMember = "idСотрудники";
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Договор №";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Рабочие часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Помещение";
            // 
            // dateContract
            // 
            this.dateContract.Location = new System.Drawing.Point(108, 3);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(200, 20);
            this.dateContract.TabIndex = 57;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.помещениеBindingSource;
            this.cmbRoom.DisplayMember = "Описание";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(108, 56);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 21);
            this.cmbRoom.TabIndex = 56;
            this.cmbRoom.ValueMember = "idПомещение";
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // помещениеBindingSource
            // 
            this.помещениеBindingSource.DataMember = "Помещение";
            this.помещениеBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(233, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(152, 136);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(75, 23);
            this.btnAddContract.TabIndex = 54;
            this.btnAddContract.Text = "Добавить";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // помещениеTableAdapter
            // 
            this.помещениеTableAdapter.ClearBeforeFill = true;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(688, 237);
            this.dataGridView1.TabIndex = 66;
            // 
            // contractViewBindingSource
            // 
            this.contractViewBindingSource.DataMember = "ContractView";
            this.contractViewBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // contractViewTableAdapter
            // 
            this.contractViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(388, 130);
            this.dataGridView2.TabIndex = 67;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 263);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договора";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(315, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(396, 156);
            this.tabControl2.TabIndex = 69;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(388, 130);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Помещения";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(687, 237);
            this.dataGridView3.TabIndex = 0;
            // 
            // TimeTableAddForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 440);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtHoursWork);
            this.Controls.Add(this.cmbContract);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateContract);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddContract);
            this.Name = "TimeTableAddForm1";
            this.Text = "TimeTableAddForm1";
            this.Load += new System.EventHandler(this.TimeTableAddForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.ComboBox cmbContract;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateContract;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddContract;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource помещениеBindingSource;
        private Studio_soundDataSetTableAdapters.ПомещениеTableAdapter помещениеTableAdapter;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private Studio_soundDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contractViewBindingSource;
        private Studio_soundDataSetTableAdapters.ContractViewTableAdapter contractViewTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}