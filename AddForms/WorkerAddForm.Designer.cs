namespace StudioSound.AddForms
{
    partial class WorkerAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameWorker = new System.Windows.Forms.TextBox();
            this.txtEmailWorker = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtPasport = new System.Windows.Forms.TextBox();
            this.txtThemeWorker = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbLeader = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.btnCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспорт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тематика работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Руководитель";
            // 
            // txtNameWorker
            // 
            this.txtNameWorker.Location = new System.Drawing.Point(117, 6);
            this.txtNameWorker.Name = "txtNameWorker";
            this.txtNameWorker.Size = new System.Drawing.Size(227, 20);
            this.txtNameWorker.TabIndex = 7;
            // 
            // txtEmailWorker
            // 
            this.txtEmailWorker.Location = new System.Drawing.Point(117, 32);
            this.txtEmailWorker.Name = "txtEmailWorker";
            this.txtEmailWorker.Size = new System.Drawing.Size(227, 20);
            this.txtEmailWorker.TabIndex = 8;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(117, 58);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(227, 20);
            this.txtPost.TabIndex = 9;
            // 
            // txtPasport
            // 
            this.txtPasport.Location = new System.Drawing.Point(117, 84);
            this.txtPasport.Name = "txtPasport";
            this.txtPasport.Size = new System.Drawing.Size(227, 20);
            this.txtPasport.TabIndex = 10;
            // 
            // txtThemeWorker
            // 
            this.txtThemeWorker.Location = new System.Drawing.Point(117, 136);
            this.txtThemeWorker.Name = "txtThemeWorker";
            this.txtThemeWorker.Size = new System.Drawing.Size(227, 20);
            this.txtThemeWorker.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // cmbLeader
            // 
            this.cmbLeader.DataSource = this.сотрудникиBindingSource;
            this.cmbLeader.DisplayMember = "ФИО";
            this.cmbLeader.FormattingEnabled = true;
            this.cmbLeader.Location = new System.Drawing.Point(117, 162);
            this.cmbLeader.Name = "cmbLeader";
            this.cmbLeader.Size = new System.Drawing.Size(227, 21);
            this.cmbLeader.TabIndex = 13;
            this.cmbLeader.ValueMember = "idСотрудники";
            this.cmbLeader.SelectedIndexChanged += new System.EventHandler(this.cmbLeader_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // studio_soundDataSet
            // 
            this.studio_soundDataSet.DataSetName = "Studio_soundDataSet";
            this.studio_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(176, 189);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(81, 37);
            this.btnAddWorker.TabIndex = 14;
            this.btnAddWorker.Text = "Добавить";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(263, 189);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(81, 37);
            this.btnCloseForm.TabIndex = 15;
            this.btnCloseForm.Text = "Закрыть";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // WorkerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(356, 240);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.cmbLeader);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtThemeWorker);
            this.Controls.Add(this.txtPasport);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtEmailWorker);
            this.Controls.Add(this.txtNameWorker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorkerAddForm";
            this.Text = "WorkerAddForm";
            this.Load += new System.EventHandler(this.WorkerAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameWorker;
        private System.Windows.Forms.TextBox txtEmailWorker;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtPasport;
        private System.Windows.Forms.TextBox txtThemeWorker;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbLeader;
        private System.Windows.Forms.Button btnAddWorker;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Button btnCloseForm;
    }
}