namespace StudioSound.AddForms
{
    partial class TimeTableAddForm
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
            this.timeTableViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableViewTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.TimeTableViewTableAdapter();
            this.contractViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ContractViewTableAdapter();
            this.contractViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.помещениеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.договорBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(108, 125);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(200, 20);
            this.txtHoursWork.TabIndex = 53;
            // 
            // cmbContract
            // 
            this.cmbContract.DataSource = this.договорBindingSource1;
            this.cmbContract.DisplayMember = "idДоговор";
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Location = new System.Drawing.Point(108, 98);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(200, 21);
            this.cmbContract.TabIndex = 52;
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
            this.cmbWorker.DataSource = this.сотрудникиBindingSource1;
            this.cmbWorker.DisplayMember = "ФИО";
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(108, 44);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 21);
            this.cmbWorker.TabIndex = 51;
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
            this.label9.Location = new System.Drawing.Point(12, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Договор №";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Рабочие часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Помещение";
            // 
            // dateContract
            // 
            this.dateContract.Location = new System.Drawing.Point(108, 18);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(200, 20);
            this.dateContract.TabIndex = 38;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.помещениеBindingSource1;
            this.cmbRoom.DisplayMember = "Описание";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(108, 71);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 21);
            this.cmbRoom.TabIndex = 37;
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
            this.btnClose.Location = new System.Drawing.Point(233, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(152, 151);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(75, 23);
            this.btnAddContract.TabIndex = 35;
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
            // timeTableViewBindingSource
            // 
            this.timeTableViewBindingSource.DataMember = "TimeTableView";
            this.timeTableViewBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // timeTableViewTableAdapter
            // 
            this.timeTableViewTableAdapter.ClearBeforeFill = true;
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
            // contractViewBindingSource2
            // 
            this.contractViewBindingSource2.DataMember = "ContractView";
            this.contractViewBindingSource2.DataSource = this.studio_soundDataSet;
            // 
            // contractViewBindingSource1
            // 
            this.contractViewBindingSource1.DataMember = "ContractView";
            this.contractViewBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // contractViewBindingSource3
            // 
            this.contractViewBindingSource3.DataMember = "ContractView";
            this.contractViewBindingSource3.DataSource = this.studio_soundDataSet;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // помещениеBindingSource1
            // 
            this.помещениеBindingSource1.DataMember = "Помещение";
            this.помещениеBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // договорBindingSource1
            // 
            this.договорBindingSource1.DataMember = "Договор";
            this.договорBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // TimeTableAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 382);
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
            this.Name = "TimeTableAddForm";
            this.Text = "TimeTableAddForm";
            this.Load += new System.EventHandler(this.TimeTableAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource timeTableViewBindingSource;
        private Studio_soundDataSetTableAdapters.TimeTableViewTableAdapter timeTableViewTableAdapter;
        private System.Windows.Forms.BindingSource contractViewBindingSource;
        private Studio_soundDataSetTableAdapters.ContractViewTableAdapter contractViewTableAdapter;
        private System.Windows.Forms.BindingSource contractViewBindingSource2;
        private System.Windows.Forms.BindingSource contractViewBindingSource1;
        private System.Windows.Forms.BindingSource contractViewBindingSource3;
        private System.Windows.Forms.BindingSource договорBindingSource1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private System.Windows.Forms.BindingSource помещениеBindingSource1;
    }
}