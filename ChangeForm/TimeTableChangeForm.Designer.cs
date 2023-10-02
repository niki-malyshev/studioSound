namespace StudioSound.ChangeForm
{
    partial class TimeTableChangeForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnChangeWorker = new System.Windows.Forms.Button();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studiosoundDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.помещениеTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ПомещениеTableAdapter();
            this.studiosoundDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ДоговорTableAdapter();
            this.договорBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ContractViewTableAdapter();
            this.contractViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contractViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contractViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочиеЧасыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тарифDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosoundDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosoundDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Включить изменение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(253, 136);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(81, 37);
            this.btnCloseForm.TabIndex = 52;
            this.btnCloseForm.Text = "Закрыть";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnChangeWorker
            // 
            this.btnChangeWorker.Enabled = false;
            this.btnChangeWorker.Location = new System.Drawing.Point(166, 136);
            this.btnChangeWorker.Name = "btnChangeWorker";
            this.btnChangeWorker.Size = new System.Drawing.Size(81, 37);
            this.btnChangeWorker.TabIndex = 51;
            this.btnChangeWorker.Text = "Изменить";
            this.btnChangeWorker.UseVisualStyleBackColor = true;
            this.btnChangeWorker.Click += new System.EventHandler(this.btnChangeWorker_Click);
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Enabled = false;
            this.txtHoursWork.Location = new System.Drawing.Point(108, 110);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(226, 20);
            this.txtHoursWork.TabIndex = 63;
            // 
            // cmbContract
            // 
            this.cmbContract.DataSource = this.договорBindingSource;
            this.cmbContract.DisplayMember = "idДоговор";
            this.cmbContract.Enabled = false;
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Location = new System.Drawing.Point(108, 83);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(226, 21);
            this.cmbContract.TabIndex = 62;
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
            this.cmbWorker.Enabled = false;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(108, 29);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(226, 21);
            this.cmbWorker.TabIndex = 61;
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
            this.label9.TabIndex = 60;
            this.label9.Text = "Договор №";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Рабочие часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Помещение";
            // 
            // dateContract
            // 
            this.dateContract.Enabled = false;
            this.dateContract.Location = new System.Drawing.Point(108, 3);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(226, 20);
            this.dateContract.TabIndex = 55;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.помещениеBindingSource;
            this.cmbRoom.DisplayMember = "Описание";
            this.cmbRoom.Enabled = false;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(108, 56);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(226, 21);
            this.cmbRoom.TabIndex = 54;
            this.cmbRoom.ValueMember = "idПомещение";
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // помещениеBindingSource
            // 
            this.помещениеBindingSource.DataMember = "Помещение";
            this.помещениеBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(67, 20);
            this.dateTimePicker1.TabIndex = 64;
            // 
            // studiosoundDataSetBindingSource
            // 
            this.studiosoundDataSetBindingSource.DataSource = this.studio_soundDataSet;
            this.studiosoundDataSetBindingSource.Position = 0;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // помещениеTableAdapter
            // 
            this.помещениеTableAdapter.ClearBeforeFill = true;
            // 
            // studiosoundDataSetBindingSource1
            // 
            this.studiosoundDataSetBindingSource1.DataSource = this.studio_soundDataSet;
            this.studiosoundDataSetBindingSource1.Position = 0;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // договорBindingSource1
            // 
            this.договорBindingSource1.DataMember = "Договор";
            this.договорBindingSource1.DataSource = this.studio_soundDataSet;
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
            // contractViewBindingSource1
            // 
            this.contractViewBindingSource1.DataMember = "ContractView";
            this.contractViewBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // contractViewBindingSource2
            // 
            this.contractViewBindingSource2.DataMember = "ContractView";
            this.contractViewBindingSource2.DataSource = this.studio_soundDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.клиентDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.датаДоговораDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.рабочиеЧасыDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.тарифDataGridViewTextBoxColumn,
            this.темаDataGridViewTextBoxColumn,
            this.номерДоговораDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractViewBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(15, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(319, 257);
            this.dataGridView1.TabIndex = 65;
            // 
            // contractViewBindingSource3
            // 
            this.contractViewBindingSource3.DataMember = "ContractView";
            this.contractViewBindingSource3.DataSource = this.studio_soundDataSet;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаДоговораDataGridViewTextBoxColumn
            // 
            this.датаДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата договора";
            this.датаДоговораDataGridViewTextBoxColumn.HeaderText = "Дата договора";
            this.датаДоговораDataGridViewTextBoxColumn.Name = "датаДоговораDataGridViewTextBoxColumn";
            this.датаДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            this.датаОкончанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рабочиеЧасыDataGridViewTextBoxColumn
            // 
            this.рабочиеЧасыDataGridViewTextBoxColumn.DataPropertyName = "Рабочие Часы";
            this.рабочиеЧасыDataGridViewTextBoxColumn.HeaderText = "Рабочие Часы";
            this.рабочиеЧасыDataGridViewTextBoxColumn.Name = "рабочиеЧасыDataGridViewTextBoxColumn";
            this.рабочиеЧасыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // тарифDataGridViewTextBoxColumn
            // 
            this.тарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф";
            this.тарифDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.тарифDataGridViewTextBoxColumn.Name = "тарифDataGridViewTextBoxColumn";
            this.тарифDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // темаDataGridViewTextBoxColumn
            // 
            this.темаDataGridViewTextBoxColumn.DataPropertyName = "Тема";
            this.темаDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.темаDataGridViewTextBoxColumn.Name = "темаDataGridViewTextBoxColumn";
            this.темаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            this.номерДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TimeTableChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 460);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnChangeWorker);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TimeTableChangeForm";
            this.Text = "TimeTableChangeForm";
            this.Load += new System.EventHandler(this.TimeTableChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosoundDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studiosoundDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractViewBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnChangeWorker;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource studiosoundDataSetBindingSource;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource помещениеBindingSource;
        private Studio_soundDataSetTableAdapters.ПомещениеTableAdapter помещениеTableAdapter;
        private System.Windows.Forms.BindingSource studiosoundDataSetBindingSource1;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private Studio_soundDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.BindingSource договорBindingSource1;
        private System.Windows.Forms.BindingSource contractViewBindingSource;
        private Studio_soundDataSetTableAdapters.ContractViewTableAdapter contractViewTableAdapter;
        private System.Windows.Forms.BindingSource contractViewBindingSource1;
        private System.Windows.Forms.BindingSource contractViewBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рабочиеЧасыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тарифDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractViewBindingSource3;
    }
}