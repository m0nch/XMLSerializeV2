namespace XMLSerializeV2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIdPrd = new System.Windows.Forms.Label();
            this.btnUpdatePrd = new System.Windows.Forms.Button();
            this.lblNamePrd = new System.Windows.Forms.Label();
            this.btnRemovePrd = new System.Windows.Forms.Button();
            this.btnAddPrd = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPricePrd = new System.Windows.Forms.TextBox();
            this.txtNamePrd = new System.Windows.Forms.TextBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.lblGuidPrd = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindOrdProds = new System.Windows.Forms.Button();
            this.txtOrdId = new System.Windows.Forms.TextBox();
            this.lblOrd = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindProdInOrd = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnUpdateOrd = new System.Windows.Forms.Button();
            this.btnRemoveOrd = new System.Windows.Forms.Button();
            this.lblGuidOrd = new System.Windows.Forms.Label();
            this.btnAddOrd = new System.Windows.Forms.Button();
            this.txtNameOrd = new System.Windows.Forms.TextBox();
            this.lblNameOrd = new System.Windows.Forms.Label();
            this.lblIdOrd = new System.Windows.Forms.Label();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.ordName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.prdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdPrd
            // 
            this.lblIdPrd.AutoSize = true;
            this.lblIdPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrd.Location = new System.Drawing.Point(9, 20);
            this.lblIdPrd.Name = "lblIdPrd";
            this.lblIdPrd.Size = new System.Drawing.Size(72, 15);
            this.lblIdPrd.TabIndex = 11;
            this.lblIdPrd.Text = "Product Id";
            // 
            // btnUpdatePrd
            // 
            this.btnUpdatePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePrd.Location = new System.Drawing.Point(419, 71);
            this.btnUpdatePrd.Name = "btnUpdatePrd";
            this.btnUpdatePrd.Size = new System.Drawing.Size(85, 23);
            this.btnUpdatePrd.TabIndex = 21;
            this.btnUpdatePrd.Text = "Update";
            this.btnUpdatePrd.UseVisualStyleBackColor = true;
            this.btnUpdatePrd.Click += new System.EventHandler(this.btnUpdatePrd_Click);
            // 
            // lblNamePrd
            // 
            this.lblNamePrd.AutoSize = true;
            this.lblNamePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrd.Location = new System.Drawing.Point(9, 48);
            this.lblNamePrd.Name = "lblNamePrd";
            this.lblNamePrd.Size = new System.Drawing.Size(45, 15);
            this.lblNamePrd.TabIndex = 12;
            this.lblNamePrd.Text = "Name";
            // 
            // btnRemovePrd
            // 
            this.btnRemovePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrd.Location = new System.Drawing.Point(419, 43);
            this.btnRemovePrd.Name = "btnRemovePrd";
            this.btnRemovePrd.Size = new System.Drawing.Size(85, 23);
            this.btnRemovePrd.TabIndex = 20;
            this.btnRemovePrd.Text = "Remove";
            this.btnRemovePrd.UseVisualStyleBackColor = true;
            this.btnRemovePrd.Click += new System.EventHandler(this.btnRemovePrd_Click);
            // 
            // btnAddPrd
            // 
            this.btnAddPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrd.Location = new System.Drawing.Point(419, 15);
            this.btnAddPrd.Name = "btnAddPrd";
            this.btnAddPrd.Size = new System.Drawing.Size(85, 23);
            this.btnAddPrd.TabIndex = 19;
            this.btnAddPrd.Text = "Add";
            this.btnAddPrd.UseVisualStyleBackColor = true;
            this.btnAddPrd.Click += new System.EventHandler(this.btnAddPrd_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(9, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 15);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // txtPricePrd
            // 
            this.txtPricePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePrd.Location = new System.Drawing.Point(55, 72);
            this.txtPricePrd.Name = "txtPricePrd";
            this.txtPricePrd.Size = new System.Drawing.Size(358, 22);
            this.txtPricePrd.TabIndex = 18;
            // 
            // txtNamePrd
            // 
            this.txtNamePrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePrd.Location = new System.Drawing.Point(55, 45);
            this.txtNamePrd.Name = "txtNamePrd";
            this.txtNamePrd.Size = new System.Drawing.Size(358, 22);
            this.txtNamePrd.TabIndex = 16;
            // 
            // grdProducts
            // 
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prdName,
            this.prdPrice,
            this.prdId});
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(0, 0);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.RowHeadersVisible = false;
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(519, 325);
            this.grdProducts.TabIndex = 22;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
            // 
            // lblGuidPrd
            // 
            this.lblGuidPrd.AutoSize = true;
            this.lblGuidPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidPrd.Location = new System.Drawing.Point(97, 21);
            this.lblGuidPrd.Name = "lblGuidPrd";
            this.lblGuidPrd.Size = new System.Drawing.Size(65, 15);
            this.lblGuidPrd.TabIndex = 23;
            this.lblGuidPrd.Text = "lblGuidPrd";
            this.lblGuidPrd.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdProducts);
            this.splitContainer1.Size = new System.Drawing.Size(519, 524);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFindOrdProds);
            this.groupBox1.Controls.Add(this.txtOrdId);
            this.groupBox1.Controls.Add(this.lblOrd);
            this.groupBox1.Controls.Add(this.txtPricePrd);
            this.groupBox1.Controls.Add(this.btnRemovePrd);
            this.groupBox1.Controls.Add(this.lblGuidPrd);
            this.groupBox1.Controls.Add(this.btnAddPrd);
            this.groupBox1.Controls.Add(this.txtNamePrd);
            this.groupBox1.Controls.Add(this.lblNamePrd);
            this.groupBox1.Controls.Add(this.lblIdPrd);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.btnUpdatePrd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 195);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products Information";
            // 
            // btnFindOrdProds
            // 
            this.btnFindOrdProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOrdProds.Location = new System.Drawing.Point(419, 159);
            this.btnFindOrdProds.Name = "btnFindOrdProds";
            this.btnFindOrdProds.Size = new System.Drawing.Size(85, 23);
            this.btnFindOrdProds.TabIndex = 40;
            this.btnFindOrdProds.Text = "Find";
            this.btnFindOrdProds.UseVisualStyleBackColor = true;
            this.btnFindOrdProds.Click += new System.EventHandler(this.btnFindOrdProds_Click);
            this.btnFindOrdProds.Leave += new System.EventHandler(this.btnFindOrdProds_Leave);
            // 
            // txtOrdId
            // 
            this.txtOrdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdId.Location = new System.Drawing.Point(71, 160);
            this.txtOrdId.Name = "txtOrdId";
            this.txtOrdId.Size = new System.Drawing.Size(339, 22);
            this.txtOrdId.TabIndex = 39;
            // 
            // lblOrd
            // 
            this.lblOrd.AutoSize = true;
            this.lblOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrd.Location = new System.Drawing.Point(5, 163);
            this.lblOrd.Name = "lblOrd";
            this.lblOrd.Size = new System.Drawing.Size(59, 15);
            this.lblOrd.TabIndex = 38;
            this.lblOrd.Text = "Order Id";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdOrders);
            this.splitContainer2.Size = new System.Drawing.Size(536, 524);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnFindProdInOrd);
            this.groupBox2.Controls.Add(this.txtProdId);
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Controls.Add(this.btnUpdateOrd);
            this.groupBox2.Controls.Add(this.btnRemoveOrd);
            this.groupBox2.Controls.Add(this.lblGuidOrd);
            this.groupBox2.Controls.Add(this.btnAddOrd);
            this.groupBox2.Controls.Add(this.txtNameOrd);
            this.groupBox2.Controls.Add(this.lblNameOrd);
            this.groupBox2.Controls.Add(this.lblIdOrd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 194);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders Information";
            // 
            // btnFindProdInOrd
            // 
            this.btnFindProdInOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProdInOrd.Location = new System.Drawing.Point(442, 159);
            this.btnFindProdInOrd.Name = "btnFindProdInOrd";
            this.btnFindProdInOrd.Size = new System.Drawing.Size(85, 23);
            this.btnFindProdInOrd.TabIndex = 37;
            this.btnFindProdInOrd.Text = "Find";
            this.btnFindProdInOrd.UseVisualStyleBackColor = true;
            this.btnFindProdInOrd.Click += new System.EventHandler(this.btnFindProdInOrd_Click);
            this.btnFindProdInOrd.Leave += new System.EventHandler(this.btnFind_Leave);
            // 
            // txtProdId
            // 
            this.txtProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdId.Location = new System.Drawing.Point(94, 160);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(339, 22);
            this.txtProdId.TabIndex = 36;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 164);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 15);
            this.lblSearch.TabIndex = 35;
            this.lblSearch.Text = "Product Id";
            // 
            // btnUpdateOrd
            // 
            this.btnUpdateOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrd.Location = new System.Drawing.Point(442, 74);
            this.btnUpdateOrd.Name = "btnUpdateOrd";
            this.btnUpdateOrd.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateOrd.TabIndex = 33;
            this.btnUpdateOrd.Text = "Update";
            this.btnUpdateOrd.UseVisualStyleBackColor = true;
            this.btnUpdateOrd.Click += new System.EventHandler(this.btnUpdateOrd_Click);
            // 
            // btnRemoveOrd
            // 
            this.btnRemoveOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrd.Location = new System.Drawing.Point(442, 46);
            this.btnRemoveOrd.Name = "btnRemoveOrd";
            this.btnRemoveOrd.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveOrd.TabIndex = 32;
            this.btnRemoveOrd.Text = "Remove";
            this.btnRemoveOrd.UseVisualStyleBackColor = true;
            this.btnRemoveOrd.Click += new System.EventHandler(this.btnRemoveOrd_Click);
            // 
            // lblGuidOrd
            // 
            this.lblGuidOrd.AutoSize = true;
            this.lblGuidOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidOrd.Location = new System.Drawing.Point(91, 20);
            this.lblGuidOrd.Name = "lblGuidOrd";
            this.lblGuidOrd.Size = new System.Drawing.Size(66, 15);
            this.lblGuidOrd.TabIndex = 34;
            this.lblGuidOrd.Text = "lblGuidOrd";
            this.lblGuidOrd.Visible = false;
            // 
            // btnAddOrd
            // 
            this.btnAddOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrd.Location = new System.Drawing.Point(442, 18);
            this.btnAddOrd.Name = "btnAddOrd";
            this.btnAddOrd.Size = new System.Drawing.Size(85, 23);
            this.btnAddOrd.TabIndex = 31;
            this.btnAddOrd.Text = "Add";
            this.btnAddOrd.UseVisualStyleBackColor = true;
            this.btnAddOrd.Click += new System.EventHandler(this.btnAddOrd_Click);
            // 
            // txtNameOrd
            // 
            this.txtNameOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOrd.Location = new System.Drawing.Point(94, 45);
            this.txtNameOrd.Name = "txtNameOrd";
            this.txtNameOrd.Size = new System.Drawing.Size(339, 22);
            this.txtNameOrd.TabIndex = 30;
            // 
            // lblNameOrd
            // 
            this.lblNameOrd.AutoSize = true;
            this.lblNameOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOrd.Location = new System.Drawing.Point(12, 48);
            this.lblNameOrd.Name = "lblNameOrd";
            this.lblNameOrd.Size = new System.Drawing.Size(45, 15);
            this.lblNameOrd.TabIndex = 29;
            this.lblNameOrd.Text = "Name";
            // 
            // lblIdOrd
            // 
            this.lblIdOrd.AutoSize = true;
            this.lblIdOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrd.Location = new System.Drawing.Point(12, 20);
            this.lblIdOrd.Name = "lblIdOrd";
            this.lblIdOrd.Size = new System.Drawing.Size(59, 15);
            this.lblIdOrd.TabIndex = 28;
            this.lblIdOrd.Text = "Order Id";
            // 
            // grdOrders
            // 
            this.grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordName,
            this.ordId});
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrders.Location = new System.Drawing.Point(0, 0);
            this.grdOrders.MultiSelect = false;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.ReadOnly = true;
            this.grdOrders.RowHeadersVisible = false;
            this.grdOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOrders.Size = new System.Drawing.Size(536, 326);
            this.grdOrders.TabIndex = 23;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            this.grdOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellDoubleClick);
            // 
            // ordName
            // 
            this.ordName.DataPropertyName = "Name";
            this.ordName.FillWeight = 10F;
            this.ordName.HeaderText = "Order Name";
            this.ordName.Name = "ordName";
            this.ordName.ReadOnly = true;
            // 
            // ordId
            // 
            this.ordId.DataPropertyName = "Id";
            this.ordId.FillWeight = 20F;
            this.ordId.HeaderText = "Order Id";
            this.ordId.Name = "ordId";
            this.ordId.ReadOnly = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(1059, 524);
            this.splitContainer3.SplitterDistance = 519;
            this.splitContainer3.TabIndex = 26;
            // 
            // prdName
            // 
            this.prdName.DataPropertyName = "Name";
            this.prdName.FillWeight = 10F;
            this.prdName.HeaderText = "Product Name";
            this.prdName.Name = "prdName";
            this.prdName.ReadOnly = true;
            // 
            // prdPrice
            // 
            this.prdPrice.DataPropertyName = "Price";
            this.prdPrice.FillWeight = 7F;
            this.prdPrice.HeaderText = "Product Price";
            this.prdPrice.Name = "prdPrice";
            this.prdPrice.ReadOnly = true;
            // 
            // prdId
            // 
            this.prdId.DataPropertyName = "Id";
            this.prdId.FillWeight = 15F;
            this.prdId.HeaderText = "Product Id";
            this.prdId.Name = "prdId";
            this.prdId.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Find all products in selected order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Find all oders contains selected product";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 524);
            this.Controls.Add(this.splitContainer3);
            this.Name = "MainForm";
            this.Text = "Products&Orders";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIdPrd;
        private System.Windows.Forms.Button btnUpdatePrd;
        private System.Windows.Forms.Label lblNamePrd;
        private System.Windows.Forms.Button btnRemovePrd;
        private System.Windows.Forms.Button btnAddPrd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPricePrd;
        private System.Windows.Forms.TextBox txtNamePrd;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Label lblGuidPrd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblGuidOrd;
        private System.Windows.Forms.TextBox txtNameOrd;
        private System.Windows.Forms.Label lblIdOrd;
        private System.Windows.Forms.Button btnUpdateOrd;
        private System.Windows.Forms.Label lblNameOrd;
        private System.Windows.Forms.Button btnAddOrd;
        private System.Windows.Forms.Button btnRemoveOrd;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordId;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnFindProdInOrd;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFindOrdProds;
        private System.Windows.Forms.TextBox txtOrdId;
        private System.Windows.Forms.Label lblOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

