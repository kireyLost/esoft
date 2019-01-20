namespace Esoft
{
    partial class Deals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deals));
            this.lblSum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_type_client = new System.Windows.Forms.ComboBox();
            this.agentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeConnect = new Esoft.HomeConnect();
            this.panelDeduction = new System.Windows.Forms.Panel();
            this.bnt_type_object = new System.Windows.Forms.Button();
            this.tb_id_com = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_type_object_com = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDeal = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_upd = new System.Windows.Forms.Button();
            this.cb_demands = new System.Windows.Forms.ComboBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.cb_supplies = new System.Windows.Forms.ComboBox();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suppliesTableAdapter = new Esoft.HomeConnectTableAdapters.suppliesTableAdapter();
            this.dealsTableAdapter = new Esoft.HomeConnectTableAdapters.dealsTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_deal_totalSum = new System.Windows.Forms.Button();
            this.btn_deduction = new System.Windows.Forms.Button();
            this.refresh_grid = new System.Windows.Forms.Button();
            this.btn_show_deal = new System.Windows.Forms.Button();
            this.agentsTableAdapter = new Esoft.HomeConnectTableAdapters.agentsTableAdapter();
            this.pc_logo = new System.Windows.Forms.PictureBox();
            this.panel_deal_totalSum = new System.Windows.Forms.Panel();
            this.lbl_company_sum = new System.Windows.Forms.Label();
            this.lbl_r_ClDown = new System.Windows.Forms.Label();
            this.lbl_clDown_sum = new System.Windows.Forms.Label();
            this.lbl_r_ClUp = new System.Windows.Forms.Label();
            this.lbl_clUp_sum = new System.Windows.Forms.Label();
            this.lbl_company = new System.Windows.Forms.Label();
            this.btn_r_up = new System.Windows.Forms.Label();
            this.btn_r_down = new System.Windows.Forms.Label();
            this.lbl_cl_up = new System.Windows.Forms.Label();
            this.lbl_cl_down = new System.Windows.Forms.Label();
            this.tb_idDeal_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sumTotal = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeConnect)).BeginInit();
            this.panelDeduction.SuspendLayout();
            this.panelDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).BeginInit();
            this.panel_deal_totalSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(295, 169);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(19, 21);
            this.lblSum.TabIndex = 112;
            this.lblSum.Text = "0";
            this.lblSum.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 111;
            this.label8.Text = "Сумма:";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 109;
            this.label6.Text = "Клиент";
            // 
            // cb_type_client
            // 
            this.cb_type_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_client.FormattingEnabled = true;
            this.cb_type_client.Items.AddRange(new object[] {
            "продавец",
            "покупатель"});
            this.cb_type_client.Location = new System.Drawing.Point(85, 76);
            this.cb_type_client.Name = "cb_type_client";
            this.cb_type_client.Size = new System.Drawing.Size(115, 29);
            this.cb_type_client.TabIndex = 110;
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
            // panelDeduction
            // 
            this.panelDeduction.Controls.Add(this.bnt_type_object);
            this.panelDeduction.Controls.Add(this.tb_id_com);
            this.panelDeduction.Controls.Add(this.label10);
            this.panelDeduction.Controls.Add(this.label9);
            this.panelDeduction.Controls.Add(this.cb_type_object_com);
            this.panelDeduction.Controls.Add(this.button1);
            this.panelDeduction.Controls.Add(this.lblSum);
            this.panelDeduction.Controls.Add(this.label8);
            this.panelDeduction.Controls.Add(this.label6);
            this.panelDeduction.Controls.Add(this.cb_type_client);
            this.panelDeduction.Controls.Add(this.label4);
            this.panelDeduction.Location = new System.Drawing.Point(459, 74);
            this.panelDeduction.Name = "panelDeduction";
            this.panelDeduction.Size = new System.Drawing.Size(394, 200);
            this.panelDeduction.TabIndex = 115;
            this.panelDeduction.Visible = false;
            // 
            // bnt_type_object
            // 
            this.bnt_type_object.FlatAppearance.BorderSize = 0;
            this.bnt_type_object.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bnt_type_object.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_type_object.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnt_type_object.Image = ((System.Drawing.Image)(resources.GetObject("bnt_type_object.Image")));
            this.bnt_type_object.Location = new System.Drawing.Point(206, 76);
            this.bnt_type_object.Name = "bnt_type_object";
            this.bnt_type_object.Size = new System.Drawing.Size(31, 28);
            this.bnt_type_object.TabIndex = 126;
            this.bnt_type_object.UseVisualStyleBackColor = true;
            this.bnt_type_object.Click += new System.EventHandler(this.bnt_type_object_Click);
            // 
            // tb_id_com
            // 
            this.tb_id_com.Location = new System.Drawing.Point(85, 43);
            this.tb_id_com.Name = "tb_id_com";
            this.tb_id_com.Size = new System.Drawing.Size(38, 27);
            this.tb_id_com.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 21);
            this.label10.TabIndex = 108;
            this.label10.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 113;
            this.label9.Text = "Объект";
            this.label9.Visible = false;
            // 
            // cb_type_object_com
            // 
            this.cb_type_object_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_object_com.FormattingEnabled = true;
            this.cb_type_object_com.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.cb_type_object_com.Location = new System.Drawing.Point(85, 117);
            this.cb_type_object_com.Name = "cb_type_object_com";
            this.cb_type_object_com.Size = new System.Drawing.Size(115, 29);
            this.cb_type_object_com.TabIndex = 114;
            this.cb_type_object_com.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(85, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 108;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 108;
            this.label4.Text = "Комиссия компании";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(35, 136);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(38, 27);
            this.tb_id.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Id";
            // 
            // panelDeal
            // 
            this.panelDeal.Controls.Add(this.tb_id);
            this.panelDeal.Controls.Add(this.label3);
            this.panelDeal.Controls.Add(this.btn_insert);
            this.panelDeal.Controls.Add(this.label7);
            this.panelDeal.Controls.Add(this.label2);
            this.panelDeal.Controls.Add(this.btn_upd);
            this.panelDeal.Controls.Add(this.cb_demands);
            this.panelDeal.Controls.Add(this.btn_del);
            this.panelDeal.Controls.Add(this.cb_supplies);
            this.panelDeal.Location = new System.Drawing.Point(439, 49);
            this.panelDeal.Name = "panelDeal";
            this.panelDeal.Size = new System.Drawing.Size(397, 185);
            this.panelDeal.TabIndex = 114;
            this.panelDeal.Visible = false;
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_insert.Location = new System.Drawing.Point(293, 130);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(101, 38);
            this.btn_insert.TabIndex = 103;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Потребность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Предложение";
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_upd.FlatAppearance.BorderSize = 0;
            this.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_upd.Location = new System.Drawing.Point(186, 130);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(101, 38);
            this.btn_upd.TabIndex = 105;
            this.btn_upd.Text = "Изменить";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // cb_demands
            // 
            this.cb_demands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_demands.FormattingEnabled = true;
            this.cb_demands.Location = new System.Drawing.Point(130, 12);
            this.cb_demands.Name = "cb_demands";
            this.cb_demands.Size = new System.Drawing.Size(121, 29);
            this.cb_demands.TabIndex = 17;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.Location = new System.Drawing.Point(79, 130);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(101, 38);
            this.btn_del.TabIndex = 104;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // cb_supplies
            // 
            this.cb_supplies.DataSource = this.suppliesBindingSource;
            this.cb_supplies.DisplayMember = "Id";
            this.cb_supplies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplies.FormattingEnabled = true;
            this.cb_supplies.Location = new System.Drawing.Point(130, 65);
            this.cb_supplies.Name = "cb_supplies";
            this.cb_supplies.Size = new System.Drawing.Size(121, 29);
            this.cb_supplies.TabIndex = 18;
            this.cb_supplies.ValueMember = "Id";
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "supplies";
            this.suppliesBindingSource.DataSource = this.homeConnect;
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
            this.demandIdDataGridViewTextBoxColumn,
            this.supplyIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dealsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(364, 392);
            this.dataGridView1.TabIndex = 111;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demandIdDataGridViewTextBoxColumn
            // 
            this.demandIdDataGridViewTextBoxColumn.DataPropertyName = "Demand_Id";
            this.demandIdDataGridViewTextBoxColumn.HeaderText = "Demand_Id";
            this.demandIdDataGridViewTextBoxColumn.Name = "demandIdDataGridViewTextBoxColumn";
            this.demandIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplyIdDataGridViewTextBoxColumn
            // 
            this.supplyIdDataGridViewTextBoxColumn.DataPropertyName = "Supply_Id";
            this.supplyIdDataGridViewTextBoxColumn.HeaderText = "Supply_Id";
            this.supplyIdDataGridViewTextBoxColumn.Name = "supplyIdDataGridViewTextBoxColumn";
            this.supplyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dealsBindingSource
            // 
            this.dealsBindingSource.DataMember = "deals";
            this.dealsBindingSource.DataSource = this.homeConnect;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Сделки";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(761, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 49);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(811, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 49);
            this.panel1.TabIndex = 110;
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
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // dealsTableAdapter
            // 
            this.dealsTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.btn_deal_totalSum);
            this.panel4.Controls.Add(this.btn_deduction);
            this.panel4.Controls.Add(this.refresh_grid);
            this.panel4.Controls.Add(this.btn_show_deal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(364, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 392);
            this.panel4.TabIndex = 127;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // btn_deal_totalSum
            // 
            this.btn_deal_totalSum.BackColor = System.Drawing.Color.Transparent;
            this.btn_deal_totalSum.FlatAppearance.BorderSize = 0;
            this.btn_deal_totalSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_deal_totalSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deal_totalSum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deal_totalSum.Image = ((System.Drawing.Image)(resources.GetObject("btn_deal_totalSum.Image")));
            this.btn_deal_totalSum.Location = new System.Drawing.Point(0, 110);
            this.btn_deal_totalSum.Name = "btn_deal_totalSum";
            this.btn_deal_totalSum.Size = new System.Drawing.Size(54, 50);
            this.btn_deal_totalSum.TabIndex = 113;
            this.btn_deal_totalSum.UseVisualStyleBackColor = false;
            this.btn_deal_totalSum.Click += new System.EventHandler(this.btn_deal_totalSum_Click);
            // 
            // btn_deduction
            // 
            this.btn_deduction.BackColor = System.Drawing.Color.Transparent;
            this.btn_deduction.FlatAppearance.BorderSize = 0;
            this.btn_deduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_deduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deduction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deduction.Image = ((System.Drawing.Image)(resources.GetObject("btn_deduction.Image")));
            this.btn_deduction.Location = new System.Drawing.Point(0, 58);
            this.btn_deduction.Name = "btn_deduction";
            this.btn_deduction.Size = new System.Drawing.Size(54, 50);
            this.btn_deduction.TabIndex = 112;
            this.btn_deduction.UseVisualStyleBackColor = false;
            this.btn_deduction.Click += new System.EventHandler(this.btn_deduction_Click);
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
            this.refresh_grid.Location = new System.Drawing.Point(0, 166);
            this.refresh_grid.Name = "refresh_grid";
            this.refresh_grid.Size = new System.Drawing.Size(54, 50);
            this.refresh_grid.TabIndex = 111;
            this.refresh_grid.UseVisualStyleBackColor = false;
            this.refresh_grid.Click += new System.EventHandler(this.refresh_grid_Click);
            // 
            // btn_show_deal
            // 
            this.btn_show_deal.BackColor = System.Drawing.Color.Transparent;
            this.btn_show_deal.FlatAppearance.BorderSize = 0;
            this.btn_show_deal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_show_deal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_deal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_show_deal.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_deal.Image")));
            this.btn_show_deal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_show_deal.Location = new System.Drawing.Point(3, 6);
            this.btn_show_deal.Name = "btn_show_deal";
            this.btn_show_deal.Size = new System.Drawing.Size(54, 50);
            this.btn_show_deal.TabIndex = 110;
            this.btn_show_deal.UseVisualStyleBackColor = false;
            this.btn_show_deal.Click += new System.EventHandler(this.btn_show_deal_Click);
            // 
            // agentsTableAdapter
            // 
            this.agentsTableAdapter.ClearBeforeFill = true;
            // 
            // pc_logo
            // 
            this.pc_logo.Image = ((System.Drawing.Image)(resources.GetObject("pc_logo.Image")));
            this.pc_logo.Location = new System.Drawing.Point(456, 98);
            this.pc_logo.Name = "pc_logo";
            this.pc_logo.Size = new System.Drawing.Size(380, 201);
            this.pc_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc_logo.TabIndex = 128;
            this.pc_logo.TabStop = false;
            // 
            // panel_deal_totalSum
            // 
            this.panel_deal_totalSum.Controls.Add(this.lbl_company_sum);
            this.panel_deal_totalSum.Controls.Add(this.lbl_r_ClDown);
            this.panel_deal_totalSum.Controls.Add(this.lbl_clDown_sum);
            this.panel_deal_totalSum.Controls.Add(this.lbl_r_ClUp);
            this.panel_deal_totalSum.Controls.Add(this.lbl_clUp_sum);
            this.panel_deal_totalSum.Controls.Add(this.lbl_company);
            this.panel_deal_totalSum.Controls.Add(this.btn_r_up);
            this.panel_deal_totalSum.Controls.Add(this.btn_r_down);
            this.panel_deal_totalSum.Controls.Add(this.lbl_cl_up);
            this.panel_deal_totalSum.Controls.Add(this.lbl_cl_down);
            this.panel_deal_totalSum.Controls.Add(this.tb_idDeal_total);
            this.panel_deal_totalSum.Controls.Add(this.label5);
            this.panel_deal_totalSum.Controls.Add(this.btn_sumTotal);
            this.panel_deal_totalSum.Controls.Add(this.label15);
            this.panel_deal_totalSum.Location = new System.Drawing.Point(448, 58);
            this.panel_deal_totalSum.Name = "panel_deal_totalSum";
            this.panel_deal_totalSum.Size = new System.Drawing.Size(405, 261);
            this.panel_deal_totalSum.TabIndex = 127;
            this.panel_deal_totalSum.Visible = false;
            // 
            // lbl_company_sum
            // 
            this.lbl_company_sum.AutoSize = true;
            this.lbl_company_sum.Location = new System.Drawing.Point(173, 229);
            this.lbl_company_sum.Name = "lbl_company_sum";
            this.lbl_company_sum.Size = new System.Drawing.Size(19, 21);
            this.lbl_company_sum.TabIndex = 136;
            this.lbl_company_sum.Text = "0";
            // 
            // lbl_r_ClDown
            // 
            this.lbl_r_ClDown.AutoSize = true;
            this.lbl_r_ClDown.Location = new System.Drawing.Point(173, 198);
            this.lbl_r_ClDown.Name = "lbl_r_ClDown";
            this.lbl_r_ClDown.Size = new System.Drawing.Size(19, 21);
            this.lbl_r_ClDown.TabIndex = 135;
            this.lbl_r_ClDown.Text = "0";
            // 
            // lbl_clDown_sum
            // 
            this.lbl_clDown_sum.AutoSize = true;
            this.lbl_clDown_sum.Location = new System.Drawing.Point(173, 167);
            this.lbl_clDown_sum.Name = "lbl_clDown_sum";
            this.lbl_clDown_sum.Size = new System.Drawing.Size(19, 21);
            this.lbl_clDown_sum.TabIndex = 134;
            this.lbl_clDown_sum.Text = "0";
            // 
            // lbl_r_ClUp
            // 
            this.lbl_r_ClUp.AutoSize = true;
            this.lbl_r_ClUp.Location = new System.Drawing.Point(173, 136);
            this.lbl_r_ClUp.Name = "lbl_r_ClUp";
            this.lbl_r_ClUp.Size = new System.Drawing.Size(19, 21);
            this.lbl_r_ClUp.TabIndex = 133;
            this.lbl_r_ClUp.Text = "0";
            // 
            // lbl_clUp_sum
            // 
            this.lbl_clUp_sum.AutoSize = true;
            this.lbl_clUp_sum.Location = new System.Drawing.Point(173, 103);
            this.lbl_clUp_sum.Name = "lbl_clUp_sum";
            this.lbl_clUp_sum.Size = new System.Drawing.Size(19, 21);
            this.lbl_clUp_sum.TabIndex = 132;
            this.lbl_clUp_sum.Text = "0";
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Location = new System.Drawing.Point(81, 229);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(95, 21);
            this.lbl_company.TabIndex = 131;
            this.lbl_company.Text = "Компания:";
            // 
            // btn_r_up
            // 
            this.btn_r_up.AutoSize = true;
            this.btn_r_up.Location = new System.Drawing.Point(4, 133);
            this.btn_r_up.Name = "btn_r_up";
            this.btn_r_up.Size = new System.Drawing.Size(172, 21);
            this.btn_r_up.TabIndex = 130;
            this.btn_r_up.Text = "Риелтор покупателя:";
            // 
            // btn_r_down
            // 
            this.btn_r_down.AutoSize = true;
            this.btn_r_down.Location = new System.Drawing.Point(14, 198);
            this.btn_r_down.Name = "btn_r_down";
            this.btn_r_down.Size = new System.Drawing.Size(162, 21);
            this.btn_r_down.TabIndex = 129;
            this.btn_r_down.Text = "Риелтор продавца:";
            // 
            // lbl_cl_up
            // 
            this.lbl_cl_up.AutoSize = true;
            this.lbl_cl_up.Location = new System.Drawing.Point(13, 103);
            this.lbl_cl_up.Name = "lbl_cl_up";
            this.lbl_cl_up.Size = new System.Drawing.Size(163, 21);
            this.lbl_cl_up.TabIndex = 128;
            this.lbl_cl_up.Text = "Клиент-покупатель:";
            // 
            // lbl_cl_down
            // 
            this.lbl_cl_down.AutoSize = true;
            this.lbl_cl_down.Location = new System.Drawing.Point(25, 167);
            this.lbl_cl_down.Name = "lbl_cl_down";
            this.lbl_cl_down.Size = new System.Drawing.Size(151, 21);
            this.lbl_cl_down.TabIndex = 127;
            this.lbl_cl_down.Text = "Клиент-продавец:";
            // 
            // tb_idDeal_total
            // 
            this.tb_idDeal_total.Location = new System.Drawing.Point(42, 49);
            this.tb_idDeal_total.Name = "tb_idDeal_total";
            this.tb_idDeal_total.Size = new System.Drawing.Size(38, 27);
            this.tb_idDeal_total.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 108;
            this.label5.Text = "Id";
            // 
            // btn_sumTotal
            // 
            this.btn_sumTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sumTotal.FlatAppearance.BorderSize = 0;
            this.btn_sumTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sumTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sumTotal.Location = new System.Drawing.Point(85, 43);
            this.btn_sumTotal.Name = "btn_sumTotal";
            this.btn_sumTotal.Size = new System.Drawing.Size(101, 38);
            this.btn_sumTotal.TabIndex = 108;
            this.btn_sumTotal.Text = "Расчитать";
            this.btn_sumTotal.UseVisualStyleBackColor = false;
            this.btn_sumTotal.Click += new System.EventHandler(this.btn_sumTotal_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(393, 21);
            this.label15.TabIndex = 108;
            this.label15.Text = "Сводка стоимости услуг и отчислений от сделок";
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 441);
            this.Controls.Add(this.panel_deal_totalSum);
            this.Controls.Add(this.panelDeduction);
            this.Controls.Add(this.panelDeal);
            this.Controls.Add(this.pc_logo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Deals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deals";
            this.Load += new System.EventHandler(this.Deals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeConnect)).EndInit();
            this.panelDeduction.ResumeLayout(false);
            this.panelDeduction.PerformLayout();
            this.panelDeal.ResumeLayout(false);
            this.panelDeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_logo)).EndInit();
            this.panel_deal_totalSum.ResumeLayout(false);
            this.panel_deal_totalSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_type_client;
        private System.Windows.Forms.Panel panelDeduction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDeal;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.ComboBox cb_demands;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox cb_supplies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private HomeConnect homeConnect;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private HomeConnectTableAdapters.suppliesTableAdapter suppliesTableAdapter;
        private System.Windows.Forms.BindingSource dealsBindingSource;
        private HomeConnectTableAdapters.dealsTableAdapter dealsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_deduction;
        private System.Windows.Forms.Button refresh_grid;
        private System.Windows.Forms.Button btn_show_deal;
        private System.Windows.Forms.BindingSource agentsBindingSource;
        private HomeConnectTableAdapters.agentsTableAdapter agentsTableAdapter;
        private System.Windows.Forms.PictureBox pc_logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_type_object_com;
        private System.Windows.Forms.TextBox tb_id_com;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bnt_type_object;
        private System.Windows.Forms.Button btn_deal_totalSum;
        private System.Windows.Forms.Panel panel_deal_totalSum;
        private System.Windows.Forms.Label lbl_company_sum;
        private System.Windows.Forms.Label lbl_r_ClDown;
        private System.Windows.Forms.Label lbl_clDown_sum;
        private System.Windows.Forms.Label lbl_r_ClUp;
        private System.Windows.Forms.Label lbl_clUp_sum;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.Label btn_r_up;
        private System.Windows.Forms.Label btn_r_down;
        private System.Windows.Forms.Label lbl_cl_up;
        private System.Windows.Forms.Label lbl_cl_down;
        private System.Windows.Forms.TextBox tb_idDeal_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sumTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}