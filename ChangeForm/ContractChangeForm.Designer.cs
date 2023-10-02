namespace StudioSound.ChangeForm
{
    partial class ContractChangeForm
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
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.cmbTarif = new System.Windows.Forms.ComboBox();
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateContract = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.клиентыTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.КлиентыTableAdapter();
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.тарифTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ТарифTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 41;
            this.checkBox1.Text = "Включить изменение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(308, 217);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(81, 37);
            this.btnCloseForm.TabIndex = 40;
            this.btnCloseForm.Text = "Закрыть";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnChangeWorker
            // 
            this.btnChangeWorker.Enabled = false;
            this.btnChangeWorker.Location = new System.Drawing.Point(221, 217);
            this.btnChangeWorker.Name = "btnChangeWorker";
            this.btnChangeWorker.Size = new System.Drawing.Size(81, 37);
            this.btnChangeWorker.TabIndex = 39;
            this.btnChangeWorker.Text = "Изменить";
            this.btnChangeWorker.UseVisualStyleBackColor = true;
            this.btnChangeWorker.Click += new System.EventHandler(this.btnChangeWorker_Click);
            // 
            // txtTheme
            // 
            this.txtTheme.Enabled = false;
            this.txtTheme.Location = new System.Drawing.Point(108, 164);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(200, 20);
            this.txtTheme.TabIndex = 57;
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Enabled = false;
            this.txtHoursWork.Location = new System.Drawing.Point(108, 138);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(200, 20);
            this.txtHoursWork.TabIndex = 56;
            // 
            // cmbTarif
            // 
            this.cmbTarif.DataSource = this.тарифBindingSource;
            this.cmbTarif.DisplayMember = "Название";
            this.cmbTarif.Enabled = false;
            this.cmbTarif.FormattingEnabled = true;
            this.cmbTarif.Location = new System.Drawing.Point(108, 190);
            this.cmbTarif.Name = "cmbTarif";
            this.cmbTarif.Size = new System.Drawing.Size(200, 21);
            this.cmbTarif.TabIndex = 55;
            this.cmbTarif.ValueMember = "idТариф";
            this.cmbTarif.SelectedIndexChanged += new System.EventHandler(this.cmbTarif_SelectedIndexChanged);
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            this.тарифBindingSource.DataSource = this.studio_soundDataSet;
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
            this.cmbWorker.Location = new System.Drawing.Point(108, 33);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 21);
            this.cmbWorker.TabIndex = 54;
            this.cmbWorker.ValueMember = "idСотрудники";
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(108, 112);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 53;
            // 
            // dateStart
            // 
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(108, 86);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Тариф";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Тема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Рабочие часы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Дата окончания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Дата начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Дата договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Сотрудник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Клиент";
            // 
            // dateContract
            // 
            this.dateContract.Enabled = false;
            this.dateContract.Location = new System.Drawing.Point(108, 60);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(200, 20);
            this.dateContract.TabIndex = 43;
            // 
            // cmbClient
            // 
            this.cmbClient.Enabled = false;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(108, 6);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 42;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(314, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 59;
            this.button1.Text = "Обновить список клиентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Enabled = false;
            this.btnAddClient.Location = new System.Drawing.Point(314, 6);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 39);
            this.btnAddClient.TabIndex = 58;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(335, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 61;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // тарифTableAdapter
            // 
            this.тарифTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(364, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // ContractChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.txtTheme);
            this.Controls.Add(this.txtHoursWork);
            this.Controls.Add(this.cmbTarif);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateContract);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnChangeWorker);
            this.Controls.Add(this.textBox1);
            this.Name = "ContractChangeForm";
            this.Text = "ContractChangeForm";
            this.Load += new System.EventHandler(this.ContractChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnChangeWorker;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.ComboBox cmbTarif;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateContract;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox textBox1;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Studio_soundDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private Studio_soundDataSetTableAdapters.ТарифTableAdapter тарифTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}