namespace StudioSound
{
    partial class WorkerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.WorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnChange = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studio_soundDataSet = new StudioSound.Studio_soundDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.СотрудникиTableAdapter();
            this.workersViewTableAdapter = new StudioSound.Studio_soundDataSetTableAdapters.WorkersViewTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsBtnAdd,
            this.tsBtnChange,
            this.tsBtnDelete,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsTxtSearch,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkerToolStripMenuItem,
            this.ContractToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.tarifToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.equipToolStripMenuItem,
            this.TimeTableToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton1.Text = "Таблицы";
            // 
            // WorkerToolStripMenuItem
            // 
            this.WorkerToolStripMenuItem.Name = "WorkerToolStripMenuItem";
            this.WorkerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.WorkerToolStripMenuItem.Text = "Сотрудники";
            this.WorkerToolStripMenuItem.Click += new System.EventHandler(this.WorkerToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ContractToolStripMenuItem.Text = "Договора";
            this.ContractToolStripMenuItem.Click += new System.EventHandler(this.ContractToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // tarifToolStripMenuItem
            // 
            this.tarifToolStripMenuItem.Name = "tarifToolStripMenuItem";
            this.tarifToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.tarifToolStripMenuItem.Text = "Тарифы";
            this.tarifToolStripMenuItem.Click += new System.EventHandler(this.tarifToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.roomToolStripMenuItem.Text = "Помещения";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // equipToolStripMenuItem
            // 
            this.equipToolStripMenuItem.Name = "equipToolStripMenuItem";
            this.equipToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.equipToolStripMenuItem.Text = "Оборудование";
            this.equipToolStripMenuItem.Click += new System.EventHandler(this.equipToolStripMenuItem_Click);
            // 
            // TimeTableToolStripMenuItem
            // 
            this.TimeTableToolStripMenuItem.Name = "TimeTableToolStripMenuItem";
            this.TimeTableToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.TimeTableToolStripMenuItem.Text = "Расписание";
            this.TimeTableToolStripMenuItem.Click += new System.EventHandler(this.TimeTableToolStripMenuItem_Click);
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdd.Image")));
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(63, 22);
            this.tsBtnAdd.Text = "Добавить";
            this.tsBtnAdd.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsBtnChange
            // 
            this.tsBtnChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnChange.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnChange.Image")));
            this.tsBtnChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnChange.Name = "tsBtnChange";
            this.tsBtnChange.Size = new System.Drawing.Size(73, 22);
            this.tsBtnChange.Text = "Подробнее";
            this.tsBtnChange.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(55, 22);
            this.tsBtnDelete.Text = "Удалить";
            this.tsBtnDelete.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Поиск: ";
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(200, 25);
            this.tsTxtSearch.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(773, 316);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // workersViewBindingSource
            // 
            this.workersViewBindingSource.DataMember = "WorkersView";
            this.workersViewBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // studio_soundDataSet
            // 
            this.studio_soundDataSet.DataSetName = "Studio_soundDataSet";
            this.studio_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.studio_soundDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // workersViewTableAdapter
            // 
            this.workersViewTableAdapter.ClearBeforeFill = true;
            // 
            // WorkerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkerListForm";
            this.Text = "Студия звукозаписи";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studio_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tsBtnChange;
        private Studio_soundDataSet studio_soundDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private Studio_soundDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource workersViewBindingSource;
        private Studio_soundDataSetTableAdapters.WorkersViewTableAdapter workersViewTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem WorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeTableToolStripMenuItem;
    }
}