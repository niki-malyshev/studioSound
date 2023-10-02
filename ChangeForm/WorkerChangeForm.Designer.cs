namespace StudioSound.ChangeForm
{
    partial class WorkerChangeForm
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
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnChangeWorker = new System.Windows.Forms.Button();
            this.cmbLeader = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtThemeWorker = new System.Windows.Forms.TextBox();
            this.txtPasport = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtEmailWorker = new System.Windows.Forms.TextBox();
            this.txtNameWorker = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdWorker = new System.Windows.Forms.TextBox();
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ДоговорTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.договорBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.раписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.раписаниеTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.РаписаниеTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.раписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(263, 189);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(81, 37);
            this.btnCloseForm.TabIndex = 31;
            this.btnCloseForm.Text = "Закрыть";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnChangeWorker
            // 
            this.btnChangeWorker.Enabled = false;
            this.btnChangeWorker.Location = new System.Drawing.Point(176, 189);
            this.btnChangeWorker.Name = "btnChangeWorker";
            this.btnChangeWorker.Size = new System.Drawing.Size(81, 37);
            this.btnChangeWorker.TabIndex = 30;
            this.btnChangeWorker.Text = "Изменить";
            this.btnChangeWorker.UseVisualStyleBackColor = true;
            this.btnChangeWorker.Click += new System.EventHandler(this.btnChangeWorker_Click);
            // 
            // cmbLeader
            // 
            this.cmbLeader.DataSource = this.сотрудникиBindingSource;
            this.cmbLeader.DisplayMember = "ФИО";
            this.cmbLeader.Enabled = false;
            this.cmbLeader.FormattingEnabled = true;
            this.cmbLeader.Location = new System.Drawing.Point(117, 162);
            this.cmbLeader.Name = "cmbLeader";
            this.cmbLeader.Size = new System.Drawing.Size(227, 21);
            this.cmbLeader.TabIndex = 29;
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
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(117, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // txtThemeWorker
            // 
            this.txtThemeWorker.Enabled = false;
            this.txtThemeWorker.Location = new System.Drawing.Point(117, 136);
            this.txtThemeWorker.Name = "txtThemeWorker";
            this.txtThemeWorker.Size = new System.Drawing.Size(227, 20);
            this.txtThemeWorker.TabIndex = 27;
            // 
            // txtPasport
            // 
            this.txtPasport.Enabled = false;
            this.txtPasport.Location = new System.Drawing.Point(117, 84);
            this.txtPasport.Name = "txtPasport";
            this.txtPasport.Size = new System.Drawing.Size(227, 20);
            this.txtPasport.TabIndex = 26;
            // 
            // txtPost
            // 
            this.txtPost.Enabled = false;
            this.txtPost.Location = new System.Drawing.Point(117, 58);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(227, 20);
            this.txtPost.TabIndex = 25;
            // 
            // txtEmailWorker
            // 
            this.txtEmailWorker.Enabled = false;
            this.txtEmailWorker.Location = new System.Drawing.Point(117, 32);
            this.txtEmailWorker.Name = "txtEmailWorker";
            this.txtEmailWorker.Size = new System.Drawing.Size(227, 20);
            this.txtEmailWorker.TabIndex = 24;
            // 
            // txtNameWorker
            // 
            this.txtNameWorker.Enabled = false;
            this.txtNameWorker.Location = new System.Drawing.Point(117, 6);
            this.txtNameWorker.Name = "txtNameWorker";
            this.txtNameWorker.Size = new System.Drawing.Size(227, 20);
            this.txtNameWorker.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Руководитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Тематика работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Паспорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ФИО";
            // 
            // txtIdWorker
            // 
            this.txtIdWorker.Location = new System.Drawing.Point(193, 198);
            this.txtIdWorker.Name = "txtIdWorker";
            this.txtIdWorker.ReadOnly = true;
            this.txtIdWorker.Size = new System.Drawing.Size(100, 20);
            this.txtIdWorker.TabIndex = 32;
            this.txtIdWorker.Visible = false;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(371, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 221);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договора";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // договорBindingSource1
            // 
            this.договорBindingSource1.DataMember = "Договор";
            this.договорBindingSource1.DataSource = this.studio_soundDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(635, 199);
            this.dataGridView2.TabIndex = 0;
            // 
            // раписаниеBindingSource
            // 
            this.раписаниеBindingSource.DataMember = "Раписание";
            this.раписаниеBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // раписаниеTableAdapter
            // 
            this.раписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Включить изменение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // WorkerChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1026, 239);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnChangeWorker);
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
            this.Controls.Add(this.txtIdWorker);
            this.Name = "WorkerChangeForm";
            this.Text = "WorkerChangeForm";
            this.Load += new System.EventHandler(this.WorkerChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.раписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnChangeWorker;
        private System.Windows.Forms.ComboBox cmbLeader;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtThemeWorker;
        private System.Windows.Forms.TextBox txtPasport;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtEmailWorker;
        private System.Windows.Forms.TextBox txtNameWorker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdWorker;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private Studio_soundDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource раписаниеBindingSource;
        private Studio_soundDataSetTableAdapters.РаписаниеTableAdapter раписаниеTableAdapter;
        private System.Windows.Forms.BindingSource договорBindingSource1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}