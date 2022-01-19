namespace XMLSerializeV2
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdProductsInOrder = new System.Windows.Forms.DataGridView();
            this.lblGuid = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNameOrd = new System.Windows.Forms.Label();
            this.lstBoxProd = new System.Windows.Forms.CheckedListBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductsInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(21, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(150, 18);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Orders Information";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(9, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 15);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 288);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(631, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdProductsInOrder
            // 
            this.grdProductsInOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductsInOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductsInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameOrd,
            this.Price});
            this.grdProductsInOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductsInOrder.Location = new System.Drawing.Point(0, 0);
            this.grdProductsInOrder.MultiSelect = false;
            this.grdProductsInOrder.Name = "grdProductsInOrder";
            this.grdProductsInOrder.ReadOnly = true;
            this.grdProductsInOrder.RowHeadersVisible = false;
            this.grdProductsInOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductsInOrder.Size = new System.Drawing.Size(728, 281);
            this.grdProductsInOrder.TabIndex = 22;
            // 
            // lblGuid
            // 
            this.lblGuid.AutoSize = true;
            this.lblGuid.Location = new System.Drawing.Point(33, 41);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Size = new System.Drawing.Size(39, 13);
            this.lblGuid.TabIndex = 23;
            this.lblGuid.Text = "lblGuid";
            this.lblGuid.Visible = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.lblNameOrd);
            this.splitContainer1.Panel1.Controls.Add(this.lstBoxProd);
            this.splitContainer1.Panel1.Controls.Add(this.lblInfo);
            this.splitContainer1.Panel1.Controls.Add(this.lblGuid);
            this.splitContainer1.Panel1.Controls.Add(this.lblId);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdProductsInOrder);
            this.splitContainer1.Size = new System.Drawing.Size(728, 607);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 24;
            // 
            // lblNameOrd
            // 
            this.lblNameOrd.AutoSize = true;
            this.lblNameOrd.Location = new System.Drawing.Point(57, 69);
            this.lblNameOrd.Name = "lblNameOrd";
            this.lblNameOrd.Size = new System.Drawing.Size(62, 13);
            this.lblNameOrd.TabIndex = 26;
            this.lblNameOrd.Text = "lblNameOrd";
            this.lblNameOrd.Visible = false;
            // 
            // lstBoxProd
            // 
            this.lstBoxProd.FormattingEnabled = true;
            this.lstBoxProd.Location = new System.Drawing.Point(339, 8);
            this.lstBoxProd.Name = "lstBoxProd";
            this.lstBoxProd.Size = new System.Drawing.Size(377, 274);
            this.lstBoxProd.TabIndex = 25;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.FillWeight = 20F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NameOrd
            // 
            this.NameOrd.DataPropertyName = "Name";
            this.NameOrd.FillWeight = 10F;
            this.NameOrd.HeaderText = "Name";
            this.NameOrd.Name = "NameOrd";
            this.NameOrd.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 5F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 607);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Students";
            this.Activated += new System.EventHandler(this.SecondForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductsInOrder)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdProductsInOrder;
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox lstBoxProd;
        private System.Windows.Forms.Label lblNameOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

