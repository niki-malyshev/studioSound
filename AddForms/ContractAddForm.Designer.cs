namespace StudioSound.AddForms
{
    partial class ContractAddForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.dateContract = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTarif = new System.Windows.Forms.ComboBox();
            this.тарифBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.тарифBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHoursWork = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.клиентыTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.КлиентыTableAdapter();
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.тарифTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ТарифTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(233, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(152, 254);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(75, 23);
            this.btnAddContract.TabIndex = 14;
            this.btnAddContract.Text = "Добавить";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(108, 6);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 16;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // studio_soundDataSet
            // 
            this.studio_soundDataSet.DataSetName = "Studio_soundDataSet";
            this.studio_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateContract
            // 
            this.dateContract.Location = new System.Drawing.Point(108, 60);
            this.dateContract.Name = "dateContract";
            this.dateContract.Size = new System.Drawing.Size(200, 20);
            this.dateContract.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата договора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Тема";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Сумма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Рабочие часы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Дата окончания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Тариф";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(108, 86);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 28;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(108, 112);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 29;
            // 
            // cmbWorker
            // 
            this.cmbWorker.DataSource = this.сотрудникиBindingSource;
            this.cmbWorker.DisplayMember = "ФИО";
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(108, 33);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(200, 21);
            this.cmbWorker.TabIndex = 30;
            this.cmbWorker.ValueMember = "idСотрудники";
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // cmbTarif
            // 
            this.cmbTarif.DataSource = this.тарифBindingSource1;
            this.cmbTarif.DisplayMember = "Название";
            this.cmbTarif.FormattingEnabled = true;
            this.cmbTarif.Location = new System.Drawing.Point(108, 190);
            this.cmbTarif.Name = "cmbTarif";
            this.cmbTarif.Size = new System.Drawing.Size(200, 21);
            this.cmbTarif.TabIndex = 31;
            this.cmbTarif.ValueMember = "idТариф";
            this.cmbTarif.SelectedIndexChanged += new System.EventHandler(this.cmbTarif_SelectedIndexChanged);
            // 
            // тарифBindingSource1
            // 
            this.тарифBindingSource1.DataMember = "Тариф";
            this.тарифBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // тарифBindingSource
            // 
            this.тарифBindingSource.DataMember = "Тариф";
            this.тарифBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // txtHoursWork
            // 
            this.txtHoursWork.Location = new System.Drawing.Point(108, 138);
            this.txtHoursWork.Name = "txtHoursWork";
            this.txtHoursWork.Size = new System.Drawing.Size(200, 20);
            this.txtHoursWork.TabIndex = 32;
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(108, 164);
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(200, 20);
            this.txtTheme.TabIndex = 33;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(314, 6);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 39);
            this.btnAddClient.TabIndex = 34;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "Обновить список клиентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContractAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 296);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.dateContract);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddContract);
            this.Name = "ContractAddForm";
            this.Text = "ContractAddForm";
            this.Load += new System.EventHandler(this.ContractAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.DateTimePicker dateContract;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.ComboBox cmbTarif;
        private System.Windows.Forms.TextBox txtHoursWork;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Button btnAddClient;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private Studio_soundDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource тарифBindingSource;
        private Studio_soundDataSetTableAdapters.ТарифTableAdapter тарифTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource тарифBindingSource1;
    }
}