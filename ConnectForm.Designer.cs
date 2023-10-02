namespace StudioSound
{
    partial class ConnectForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameSrv = new System.Windows.Forms.Label();
            this.lblNameDB = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTypeAutor = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbTypeAutor = new System.Windows.Forms.ComboBox();
            this.txtNameDB = new System.Windows.Forms.TextBox();
            this.txtNameSrv = new System.Windows.Forms.TextBox();
            this.bttConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameSrv
            // 
            this.lblNameSrv.AutoSize = true;
            this.lblNameSrv.Location = new System.Drawing.Point(90, 24);
            this.lblNameSrv.Name = "lblNameSrv";
            this.lblNameSrv.Size = new System.Drawing.Size(77, 13);
            this.lblNameSrv.TabIndex = 0;
            this.lblNameSrv.Text = "Имя сервера:";
            // 
            // lblNameDB
            // 
            this.lblNameDB.AutoSize = true;
            this.lblNameDB.Location = new System.Drawing.Point(106, 59);
            this.lblNameDB.Name = "lblNameDB";
            this.lblNameDB.Size = new System.Drawing.Size(61, 13);
            this.lblNameDB.TabIndex = 1;
            this.lblNameDB.Text = "Имя базы:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(61, 135);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(106, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Имя пользователя:";
            // 
            // lblTypeAutor
            // 
            this.lblTypeAutor.AutoSize = true;
            this.lblTypeAutor.Location = new System.Drawing.Point(39, 96);
            this.lblTypeAutor.Name = "lblTypeAutor";
            this.lblTypeAutor.Size = new System.Drawing.Size(128, 13);
            this.lblTypeAutor.TabIndex = 2;
            this.lblTypeAutor.Text = "Проверка подлинности:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(119, 169);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(48, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Пароль:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(173, 132);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(191, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(173, 166);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 20);
            this.txtPass.TabIndex = 7;
            // 
            // cmbTypeAutor
            // 
            this.cmbTypeAutor.FormattingEnabled = true;
            this.cmbTypeAutor.Items.AddRange(new object[] {
            "Проверка подлинности Windows",
            "Проверка подлинности SQL Server"});
            this.cmbTypeAutor.Location = new System.Drawing.Point(173, 93);
            this.cmbTypeAutor.Name = "cmbTypeAutor";
            this.cmbTypeAutor.Size = new System.Drawing.Size(191, 21);
            this.cmbTypeAutor.TabIndex = 10;
            this.cmbTypeAutor.SelectionChangeCommitted += new System.EventHandler(this.cmbTypeAutor_SelectionChangeCommitted);
            // 
            // txtNameDB
            // 
            this.txtNameDB.Location = new System.Drawing.Point(173, 56);
            this.txtNameDB.Name = "txtNameDB";
            this.txtNameDB.Size = new System.Drawing.Size(191, 20);
            this.txtNameDB.TabIndex = 12;
            this.txtNameDB.Text = "Studio_sound";
            // 
            // txtNameSrv
            // 
            this.txtNameSrv.Location = new System.Drawing.Point(173, 21);
            this.txtNameSrv.Name = "txtNameSrv";
            this.txtNameSrv.Size = new System.Drawing.Size(191, 20);
            this.txtNameSrv.TabIndex = 11;
            this.txtNameSrv.Text = "NIKITA-PC\\SQLEXPRESS";
            // 
            // bttConnect
            // 
            this.bttConnect.Location = new System.Drawing.Point(288, 196);
            this.bttConnect.Name = "bttConnect";
            this.bttConnect.Size = new System.Drawing.Size(75, 23);
            this.bttConnect.TabIndex = 13;
            this.bttConnect.Text = "Соединить";
            this.bttConnect.UseVisualStyleBackColor = true;
            this.bttConnect.Click += new System.EventHandler(this.bttConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 231);
            this.Controls.Add(this.bttConnect);
            this.Controls.Add(this.txtNameDB);
            this.Controls.Add(this.txtNameSrv);
            this.Controls.Add(this.cmbTypeAutor);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTypeAutor);
            this.Controls.Add(this.lblNameDB);
            this.Controls.Add(this.lblNameSrv);
            this.Name = "Form1";
            this.Text = "Введите параметры подключение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSrv;
        private System.Windows.Forms.Label lblNameDB;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTypeAutor;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cmbTypeAutor;
        private System.Windows.Forms.TextBox txtNameDB;
        private System.Windows.Forms.TextBox txtNameSrv;
        private System.Windows.Forms.Button bttConnect;
    }
}

