namespace Prj_Pharmacy.Pharmacist_US
{
    partial class US_Ph_SellMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Ph_SellMedicine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpExpire = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddToCart = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNofUnits = new System.Windows.Forms.TextBox();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dgvMedicines = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NofUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new Guna.UI.WinForms.GunaButton();
            this.btnPurchse = new Guna.UI.WinForms.GunaButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstMedicines = new System.Windows.Forms.ListBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(249, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Medicine Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(249, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 63;
            this.label9.Text = "Medicine Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 246);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 62;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(252, 180);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(222, 20);
            this.txtCode.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(249, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 66;
            this.label11.Text = "Expire Date";
            // 
            // dtpExpire
            // 
            this.dtpExpire.BorderThickness = 1;
            this.dtpExpire.CheckedState.Parent = this.dtpExpire;
            this.dtpExpire.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpire.HoverState.Parent = this.dtpExpire;
            this.dtpExpire.Location = new System.Drawing.Point(252, 313);
            this.dtpExpire.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpire.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.ShadowDecoration.Parent = this.dtpExpire;
            this.dtpExpire.Size = new System.Drawing.Size(222, 20);
            this.dtpExpire.TabIndex = 65;
            this.dtpExpire.Value = new System.DateTime(2022, 2, 9, 16, 26, 14, 59);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.AnimationHoverSpeed = 0.07F;
            this.btnAddToCart.AnimationSpeed = 0.03F;
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.BorderColor = System.Drawing.Color.Black;
            this.btnAddToCart.BorderSize = 1;
            this.btnAddToCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddToCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageSize = new System.Drawing.Size(22, 22);
            this.btnAddToCart.Location = new System.Drawing.Point(684, 359);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddToCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddToCart.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.OnHoverImage = null;
            this.btnAddToCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddToCart.Radius = 18;
            this.btnAddToCart.Size = new System.Drawing.Size(127, 36);
            this.btnAddToCart.TabIndex = 67;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(343, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 68;
            this.label1.Text = "Sell Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(558, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "N of Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(558, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "Price Per Unit";
            // 
            // txtNofUnits
            // 
            this.txtNofUnits.Location = new System.Drawing.Point(561, 246);
            this.txtNofUnits.Name = "txtNofUnits";
            this.txtNofUnits.Size = new System.Drawing.Size(222, 20);
            this.txtNofUnits.TabIndex = 70;
            this.txtNofUnits.TextChanged += new System.EventHandler(this.txtNofUnits_TextChanged);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(561, 180);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(222, 20);
            this.txtPricePerUnit.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(558, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(561, 313);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(222, 20);
            this.txtTotalPrice.TabIndex = 73;
            // 
            // dgvMedicines
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.NameMedicine,
            this.ExpireDate,
            this.PricePerUnit,
            this.NofUnits,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicines.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicines.EnableHeadersVisualStyles = false;
            this.dgvMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicines.Location = new System.Drawing.Point(252, 425);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(559, 192);
            this.dgvMedicines.TabIndex = 76;
            this.dgvMedicines.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMedicines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicines.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicines.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicines.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicines.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicines.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvMedicines.ThemeStyle.ReadOnly = false;
            this.dgvMedicines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicines.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMedicines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicines.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedicines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // NameMedicine
            // 
            this.NameMedicine.HeaderText = "Name Medicine";
            this.NameMedicine.Name = "NameMedicine";
            // 
            // ExpireDate
            // 
            this.ExpireDate.HeaderText = "Expire Date";
            this.ExpireDate.Name = "ExpireDate";
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.HeaderText = "Price Per Unit";
            this.PricePerUnit.Name = "PricePerUnit";
            // 
            // NofUnits
            // 
            this.NofUnits.HeaderText = "N of Units";
            this.NofUnits.Name = "NofUnits";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.BorderSize = 1;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Location = new System.Drawing.Point(277, 623);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Radius = 18;
            this.btnRemove.Size = new System.Drawing.Size(102, 36);
            this.btnRemove.TabIndex = 77;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPurchse
            // 
            this.btnPurchse.AnimationHoverSpeed = 0.07F;
            this.btnPurchse.AnimationSpeed = 0.03F;
            this.btnPurchse.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchse.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnPurchse.BorderColor = System.Drawing.Color.Black;
            this.btnPurchse.BorderSize = 1;
            this.btnPurchse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPurchse.FocusedColor = System.Drawing.Color.Empty;
            this.btnPurchse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchse.ForeColor = System.Drawing.Color.White;
            this.btnPurchse.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchse.Image")));
            this.btnPurchse.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPurchse.Location = new System.Drawing.Point(656, 623);
            this.btnPurchse.Name = "btnPurchse";
            this.btnPurchse.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPurchse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPurchse.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPurchse.OnHoverImage = null;
            this.btnPurchse.OnPressedColor = System.Drawing.Color.Black;
            this.btnPurchse.Radius = 18;
            this.btnPurchse.Size = new System.Drawing.Size(155, 36);
            this.btnPurchse.TabIndex = 78;
            this.btnPurchse.Text = "Purchase & Print";
            this.btnPurchse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPurchse.Click += new System.EventHandler(this.btnPurchse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(77, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 80;
            this.label6.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(66, 180);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 20);
            this.txtSearch.TabIndex = 79;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstMedicines
            // 
            this.lstMedicines.FormattingEnabled = true;
            this.lstMedicines.Location = new System.Drawing.Point(60, 218);
            this.lstMedicines.Name = "lstMedicines";
            this.lstMedicines.Size = new System.Drawing.Size(132, 342);
            this.lstMedicines.TabIndex = 81;
            this.lstMedicines.SelectedIndexChanged += new System.EventHandler(this.lstMedicines_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRefresh.Location = new System.Drawing.Point(553, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(31, 27);
            this.btnRefresh.TabIndex = 83;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultat.Location = new System.Drawing.Point(497, 634);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(14, 15);
            this.lblResultat.TabIndex = 84;
            this.lblResultat.Text = "0";
            // 
            // US_Ph_SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstMedicines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPurchse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNofUnits);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpExpire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Name = "US_Ph_SellMedicine";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_Ph_SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpire;
        private Guna.UI.WinForms.GunaButton btnAddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNofUnits;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicines;
        private Guna.UI.WinForms.GunaButton btnRemove;
        private Guna.UI.WinForms.GunaButton btnPurchse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstMedicines;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NofUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblResultat;
    }
}
