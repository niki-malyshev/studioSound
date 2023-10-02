namespace StudioSound.ChangeForm
{
    partial class EquipChangeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.помещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.помещениеTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.ПомещениеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Включить изменение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(250, 112);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(81, 37);
            this.btnCloseForm.TabIndex = 43;
            this.btnCloseForm.Text = "Закрыть";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnChangeWorker
            // 
            this.btnChangeWorker.Enabled = false;
            this.btnChangeWorker.Location = new System.Drawing.Point(163, 112);
            this.btnChangeWorker.Name = "btnChangeWorker";
            this.btnChangeWorker.Size = new System.Drawing.Size(81, 37);
            this.btnChangeWorker.TabIndex = 42;
            this.btnChangeWorker.Text = "Изменить";
            this.btnChangeWorker.UseVisualStyleBackColor = true;
            this.btnChangeWorker.Click += new System.EventHandler(this.btnChangeWorker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Исправность";
            // 
            // txtOther
            // 
            this.txtOther.Enabled = false;
            this.txtOther.Location = new System.Drawing.Point(102, 86);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(229, 20);
            this.txtOther.TabIndex = 50;
            // 
            // cmbCheck
            // 
            this.cmbCheck.Enabled = false;
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "Неисправно",
            "Исправно"});
            this.cmbCheck.Location = new System.Drawing.Point(102, 59);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(229, 21);
            this.cmbCheck.TabIndex = 49;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.cmbCheck_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Название";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.помещениеBindingSource;
            this.cmbRoom.DisplayMember = "Описание";
            this.cmbRoom.Enabled = false;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(102, 6);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(229, 21);
            this.cmbRoom.TabIndex = 47;
            this.cmbRoom.ValueMember = "idПомещение";
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(102, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Помещение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(325, 283);
            this.dataGridView1.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 54;
            // 
            // studio_soundDataSet
            // 
            this.studio_soundDataSet.DataSetName = "Studio_soundDataSet";
            this.studio_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // помещениеBindingSource
            // 
            this.помещениеBindingSource.DataMember = "Помещение";
            this.помещениеBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // помещениеTableAdapter
            // 
            this.помещениеTableAdapter.ClearBeforeFill = true;
            // 
            // EquipChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnChangeWorker);
            this.Controls.Add(this.textBox1);
            this.Name = "EquipChangeForm";
            this.Text = "EquipChangeForm";
            this.Load += new System.EventHandler(this.EquipChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.помещениеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnChangeWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.ComboBox cmbCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource помещениеBindingSource;
        private Studio_soundDataSetTableAdapters.ПомещениеTableAdapter помещениеTableAdapter;
    }
}