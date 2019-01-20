namespace Esoft
{
    partial class MenuRieltors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRieltors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealShareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeConnect = new Esoft.HomeConnect();
            this.agentsTableAdapter = new Esoft.HomeConnectTableAdapters.agentsTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.refresh_grid = new System.Windows.Forms.Button();
            this.btn_show_slide = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find_cl = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_ds = new System.Windows.Forms.TextBox();
            this.tb_FN = new System.Windows.Forms.TextBox();
            this.tb_MN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_LN = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.pc_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeConnect)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 49);
            this.panel1.TabIndex = 53;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Риелторы";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(1008, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(50, 49);
            this.btnMinimized.TabIndex = 1;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1058, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dealShareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 494);
            this.dataGridView1.TabIndex = 54;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealShareDataGridViewTextBoxColumn
            // 
            this.dealShareDataGridViewTextBoxColumn.DataPropertyName = "DealShare";
            this.dealShareDataGridViewTextBoxColumn.HeaderText = "DealShare";
            this.dealShareDataGridViewTextBoxColumn.Name = "dealShareDataGridViewTextBoxColumn";
            this.dealShareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agentsBindingSource
            // 
            this.agentsBindingSource.DataMember = "agents";
            this.agentsBindingSource.DataSource = this.homeConnect;
            // 
            // homeConnect
            // 
            this.homeConnect.DataSetName = "HomeConnect";
            this.homeConnect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.refresh_grid);
            this.panel3.Controls.Add(this.btn_show_slide);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(618, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 494);
            this.panel3.TabIndex = 58;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // refresh_grid
            // 
            this.refresh_grid.BackColor = System.Drawing.Color.Transparent;
            this.refresh_grid.FlatAppearance.BorderSize = 0;
            this.refresh_grid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.refresh_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_grid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_grid.Image = ((System.Drawing.Image)(resources.GetObject("refresh_grid.Image")));
            this.refresh_grid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_grid.Location = new System.Drawing.Point(1, 60);
            this.refresh_grid.Name = "refresh_grid";
            this.refresh_grid.Size = new System.Drawing.Size(54, 50);
            this.refresh_grid.TabIndex = 111;
            this.refresh_grid.UseVisualStyleBackColor = false;
            this.refresh_grid.Click += new System.EventHandler(this.refresh_grid_Click);
            this.refresh_grid.MouseHover += new System.EventHandler(this.refresh_grid_MouseHover);
            // 
            // btn_show_slide
            // 
            this.btn_show_slide.BackColor = System.Drawing.Color.Transparent;
            this.btn_show_slide.FlatAppearance.BorderSize = 0;
            this.btn_show_slide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_show_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_slide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_show_slide.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_slide.Image")));
            this.btn_show_slide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show_slide.Location = new System.Drawing.Point(3, 6);
            this.btn_show_slide.Name = "btn_show_slide";
            this.btn_show_slide.Size = new System.Drawing.Size(54, 50);
            this.btn_show_slide.TabIndex = 110;
            this.btn_show_slide.UseVisualStyleBackColor = false;
            this.btn_show_slide.Click += new System.EventHandler(this.btn_show_slide_Click);
            this.btn_show_slide.MouseHover += new System.EventHandler(this.btn_show_slide_MouseHover);
            // 
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.label2);
            this.panelSlide.Controls.Add(this.btn_find_cl);
            this.panelSlide.Controls.Add(this.textBox1);
            this.panelSlide.Controls.Add(this.pictureBox2);
            this.panelSlide.Controls.Add(this.pictureBox3);
            this.panelSlide.Controls.Add(this.tb_ds);
            this.panelSlide.Controls.Add(this.tb_FN);
            this.panelSlide.Controls.Add(this.tb_MN);
            this.panelSlide.Controls.Add(this.label12);
            this.panelSlide.Controls.Add(this.label11);
            this.panelSlide.Controls.Add(this.label10);
            this.panelSlide.Controls.Add(this.label17);
            this.panelSlide.Controls.Add(this.tb_LN);
            this.panelSlide.Controls.Add(this.btn_insert);
            this.panelSlide.Controls.Add(this.label9);
            this.panelSlide.Controls.Add(this.lblInfo);
            this.panelSlide.Controls.Add(this.tb_id);
            this.panelSlide.Controls.Add(this.btn_del);
            this.panelSlide.Controls.Add(this.btn_upd);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(678, 49);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(434, 494);
            this.panelSlide.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 129;
            this.label2.Text = "ФИО";
            // 
            // btn_find_cl
            // 
            this.btn_find_cl.BackColor = System.Drawing.Color.Transparent;
            this.btn_find_cl.FlatAppearance.BorderSize = 0;
            this.btn_find_cl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_find_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find_cl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_find_cl.Image = ((System.Drawing.Image)(resources.GetObject("btn_find_cl.Image")));
            this.btn_find_cl.Location = new System.Drawing.Point(335, 368);
            this.btn_find_cl.Name = "btn_find_cl";
            this.btn_find_cl.Size = new System.Drawing.Size(35, 35);
            this.btn_find_cl.TabIndex = 127;
            this.btn_find_cl.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 128;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(57, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 120;
            this.pictureBox3.TabStop = false;
            // 
            // tb_ds
            // 
            this.tb_ds.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ds.Location = new System.Drawing.Point(186, 146);
            this.tb_ds.Name = "tb_ds";
            this.tb_ds.Size = new System.Drawing.Size(191, 27);
            this.tb_ds.TabIndex = 118;
            this.tb_ds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ds_KeyPress);
            // 
            // tb_FN
            // 
            this.tb_FN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FN.Location = new System.Drawing.Point(186, 57);
            this.tb_FN.Name = "tb_FN";
            this.tb_FN.Size = new System.Drawing.Size(191, 27);
            this.tb_FN.TabIndex = 116;
            this.tb_FN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FN_KeyPress);
            // 
            // tb_MN
            // 
            this.tb_MN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MN.Location = new System.Drawing.Point(186, 90);
            this.tb_MN.Name = "tb_MN";
            this.tb_MN.Size = new System.Drawing.Size(191, 27);
            this.tb_MN.TabIndex = 117;
            this.tb_MN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MN_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(114, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 114;
            this.label12.Text = "Ставка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(100, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 113;
            this.label11.Text = "Отчество";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(137, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 112;
            this.label10.Text = "Имя";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(95, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 21);
            this.label17.TabIndex = 111;
            this.label17.Text = "Фамилия";
            // 
            // tb_LN
            // 
            this.tb_LN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_LN.Location = new System.Drawing.Point(186, 23);
            this.tb_LN.Name = "tb_LN";
            this.tb_LN.Size = new System.Drawing.Size(191, 27);
            this.tb_LN.TabIndex = 110;
            this.tb_LN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_LN_KeyPress);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_insert.Location = new System.Drawing.Point(313, 216);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(101, 38);
            this.btn_insert.TabIndex = 123;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 21);
            this.label9.TabIndex = 104;
            this.label9.Text = "Id";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(228, 269);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(57, 21);
            this.lblInfo.TabIndex = 109;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.Visible = false;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_id.Location = new System.Drawing.Point(49, 222);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(38, 27);
            this.tb_id.TabIndex = 120;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(99, 216);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(101, 38);
            this.btn_del.TabIndex = 121;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_upd.FlatAppearance.BorderSize = 0;
            this.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_upd.Location = new System.Drawing.Point(206, 216);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(101, 38);
            this.btn_upd.TabIndex = 122;
            this.btn_upd.Text = "Изменить";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // pc_logo
            // 
            this.pc_logo.Image = ((System.Drawing.Image)(resources.GetObject("pc_logo.Image")));
            this.pc_logo.Location = new System.Drawing.Point(684, 148);
            this.pc_logo.Name = "pc_logo";
            this.pc_logo.Size = new System.Drawing.Size(402, 201);
            this.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc_logo.TabIndex = 130;
            this.pc_logo.TabStop = false;
            // 
            // MenuRieltors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1108, 543);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.pc_logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MenuRieltors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риелторы";
            this.Load += new System.EventHandler(this.MenuRieltors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeConnect)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HomeConnect homeConnect;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private HomeConnectTableAdapters.agentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealShareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button refresh_grid;
        private System.Windows.Forms.Button btn_show_slide;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tb_ds;
        private System.Windows.Forms.TextBox tb_FN;
        private System.Windows.Forms.TextBox tb_MN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_LN;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find_cl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pc_logo;
    }
}