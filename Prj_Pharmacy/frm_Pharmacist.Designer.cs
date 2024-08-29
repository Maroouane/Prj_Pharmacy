namespace Prj_Pharmacy
{
    partial class frm_Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnLougOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnValidityMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashBord = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDashBord = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.uS_Ph_SellMedicine1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_SellMedicine();
            this.uS_Ph_ValidityCheck1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_ValidityCheck();
            this.uS_Ph_ModifyMedicine1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_ModifyMedicine();
            this.uS_Ph_ViewMedicines1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_ViewMedicines();
            this.uS_Ph_DashBord1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_DashBord();
            this.uS_Ph_AddMedicine1 = new Prj_Pharmacy.Pharmacist_US.US_Ph_AddMedicine();
            this.panel1.SuspendLayout();
            this.pnlDashBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnPrintMedicine);
            this.panel1.Controls.Add(this.btnLougOut);
            this.panel1.Controls.Add(this.btnSellMed);
            this.panel1.Controls.Add(this.btnValidityMed);
            this.panel1.Controls.Add(this.btnModifyMed);
            this.panel1.Controls.Add(this.btnViewMed);
            this.panel1.Controls.Add(this.btnAddMed);
            this.panel1.Controls.Add(this.btnDashBord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 770);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintMedicine
            // 
            this.btnPrintMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPrintMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPrintMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPrintMedicine.CheckedState.Parent = this.btnPrintMedicine;
            this.btnPrintMedicine.CustomImages.Parent = this.btnPrintMedicine;
            this.btnPrintMedicine.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMedicine.ForeColor = System.Drawing.Color.White;
            this.btnPrintMedicine.HoverState.Parent = this.btnPrintMedicine;
            this.btnPrintMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintMedicine.Image")));
            this.btnPrintMedicine.Location = new System.Drawing.Point(0, 488);
            this.btnPrintMedicine.Name = "btnPrintMedicine";
            this.btnPrintMedicine.ShadowDecoration.Parent = this.btnPrintMedicine;
            this.btnPrintMedicine.Size = new System.Drawing.Size(203, 45);
            this.btnPrintMedicine.TabIndex = 10;
            this.btnPrintMedicine.Text = "Print Medicines";
            this.btnPrintMedicine.Click += new System.EventHandler(this.btnPrintMedicine_Click);
            // 
            // btnLougOut
            // 
            this.btnLougOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLougOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLougOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLougOut.CheckedState.Parent = this.btnLougOut;
            this.btnLougOut.CustomImages.Parent = this.btnLougOut;
            this.btnLougOut.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLougOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLougOut.ForeColor = System.Drawing.Color.White;
            this.btnLougOut.HoverState.Parent = this.btnLougOut;
            this.btnLougOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLougOut.Image")));
            this.btnLougOut.Location = new System.Drawing.Point(1, 537);
            this.btnLougOut.Name = "btnLougOut";
            this.btnLougOut.ShadowDecoration.Parent = this.btnLougOut;
            this.btnLougOut.Size = new System.Drawing.Size(203, 45);
            this.btnLougOut.TabIndex = 9;
            this.btnLougOut.Text = "Log Out";
            this.btnLougOut.Click += new System.EventHandler(this.btnLougOut_Click);
            // 
            // btnSellMed
            // 
            this.btnSellMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMed.CheckedState.Parent = this.btnSellMed;
            this.btnSellMed.CustomImages.Parent = this.btnSellMed;
            this.btnSellMed.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSellMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMed.ForeColor = System.Drawing.Color.White;
            this.btnSellMed.HoverState.Parent = this.btnSellMed;
            this.btnSellMed.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMed.Image")));
            this.btnSellMed.Location = new System.Drawing.Point(0, 437);
            this.btnSellMed.Name = "btnSellMed";
            this.btnSellMed.ShadowDecoration.Parent = this.btnSellMed;
            this.btnSellMed.Size = new System.Drawing.Size(203, 45);
            this.btnSellMed.TabIndex = 8;
            this.btnSellMed.Text = "Sell Medecine";
            this.btnSellMed.Click += new System.EventHandler(this.btnSellMed_Click);
            // 
            // btnValidityMed
            // 
            this.btnValidityMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnValidityMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnValidityMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnValidityMed.CheckedState.Parent = this.btnValidityMed;
            this.btnValidityMed.CustomImages.Parent = this.btnValidityMed;
            this.btnValidityMed.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnValidityMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidityMed.ForeColor = System.Drawing.Color.White;
            this.btnValidityMed.HoverState.Parent = this.btnValidityMed;
            this.btnValidityMed.Image = ((System.Drawing.Image)(resources.GetObject("btnValidityMed.Image")));
            this.btnValidityMed.Location = new System.Drawing.Point(1, 392);
            this.btnValidityMed.Name = "btnValidityMed";
            this.btnValidityMed.ShadowDecoration.Parent = this.btnValidityMed;
            this.btnValidityMed.Size = new System.Drawing.Size(202, 45);
            this.btnValidityMed.TabIndex = 7;
            this.btnValidityMed.Text = "Validity Check";
            this.btnValidityMed.Click += new System.EventHandler(this.btnValidityMed_Click);
            // 
            // btnModifyMed
            // 
            this.btnModifyMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMed.CheckedState.Parent = this.btnModifyMed;
            this.btnModifyMed.CustomImages.Parent = this.btnModifyMed;
            this.btnModifyMed.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnModifyMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMed.ForeColor = System.Drawing.Color.White;
            this.btnModifyMed.HoverState.Parent = this.btnModifyMed;
            this.btnModifyMed.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMed.Image")));
            this.btnModifyMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnModifyMed.Location = new System.Drawing.Point(0, 347);
            this.btnModifyMed.Name = "btnModifyMed";
            this.btnModifyMed.ShadowDecoration.Parent = this.btnModifyMed;
            this.btnModifyMed.Size = new System.Drawing.Size(203, 45);
            this.btnModifyMed.TabIndex = 6;
            this.btnModifyMed.Text = "Modify Medicine";
            this.btnModifyMed.Click += new System.EventHandler(this.btnModifyMed_Click);
            // 
            // btnViewMed
            // 
            this.btnViewMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMed.CheckedState.Parent = this.btnViewMed;
            this.btnViewMed.CustomImages.Parent = this.btnViewMed;
            this.btnViewMed.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnViewMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMed.ForeColor = System.Drawing.Color.White;
            this.btnViewMed.HoverState.Parent = this.btnViewMed;
            this.btnViewMed.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMed.Image")));
            this.btnViewMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewMed.Location = new System.Drawing.Point(0, 302);
            this.btnViewMed.Name = "btnViewMed";
            this.btnViewMed.ShadowDecoration.Parent = this.btnViewMed;
            this.btnViewMed.Size = new System.Drawing.Size(203, 45);
            this.btnViewMed.TabIndex = 5;
            this.btnViewMed.Text = "View Medicine";
            this.btnViewMed.Click += new System.EventHandler(this.btnViewMed_Click);
            // 
            // btnAddMed
            // 
            this.btnAddMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMed.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMed.CheckedState.Parent = this.btnAddMed;
            this.btnAddMed.CustomImages.Parent = this.btnAddMed;
            this.btnAddMed.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMed.ForeColor = System.Drawing.Color.White;
            this.btnAddMed.HoverState.Parent = this.btnAddMed;
            this.btnAddMed.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMed.Image")));
            this.btnAddMed.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMed.Location = new System.Drawing.Point(0, 257);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.ShadowDecoration.Parent = this.btnAddMed;
            this.btnAddMed.Size = new System.Drawing.Size(203, 45);
            this.btnAddMed.TabIndex = 4;
            this.btnAddMed.Text = "Add Medicine";
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // btnDashBord
            // 
            this.btnDashBord.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDashBord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashBord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashBord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashBord.CheckedState.Parent = this.btnDashBord;
            this.btnDashBord.CustomImages.Parent = this.btnDashBord;
            this.btnDashBord.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDashBord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBord.ForeColor = System.Drawing.Color.White;
            this.btnDashBord.HoverState.Parent = this.btnDashBord;
            this.btnDashBord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBord.Image")));
            this.btnDashBord.Location = new System.Drawing.Point(0, 212);
            this.btnDashBord.Name = "btnDashBord";
            this.btnDashBord.ShadowDecoration.Parent = this.btnDashBord;
            this.btnDashBord.Size = new System.Drawing.Size(203, 45);
            this.btnDashBord.TabIndex = 3;
            this.btnDashBord.Text = "DashBord";
            this.btnDashBord.Click += new System.EventHandler(this.btnDashBord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // pnlDashBord
            // 
            this.pnlDashBord.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDashBord.Controls.Add(this.uS_Ph_SellMedicine1);
            this.pnlDashBord.Controls.Add(this.uS_Ph_ValidityCheck1);
            this.pnlDashBord.Controls.Add(this.uS_Ph_ModifyMedicine1);
            this.pnlDashBord.Controls.Add(this.uS_Ph_ViewMedicines1);
            this.pnlDashBord.Controls.Add(this.uS_Ph_DashBord1);
            this.pnlDashBord.Controls.Add(this.uS_Ph_AddMedicine1);
            this.pnlDashBord.ForeColor = System.Drawing.Color.White;
            this.pnlDashBord.Location = new System.Drawing.Point(203, 0);
            this.pnlDashBord.Name = "pnlDashBord";
            this.pnlDashBord.Size = new System.Drawing.Size(859, 770);
            this.pnlDashBord.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // uS_Ph_SellMedicine1
            // 
            this.uS_Ph_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_SellMedicine1.Location = new System.Drawing.Point(0, 1);
            this.uS_Ph_SellMedicine1.Name = "uS_Ph_SellMedicine1";
            this.uS_Ph_SellMedicine1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_SellMedicine1.TabIndex = 6;
            // 
            // uS_Ph_ValidityCheck1
            // 
            this.uS_Ph_ValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_ValidityCheck1.Location = new System.Drawing.Point(0, 1);
            this.uS_Ph_ValidityCheck1.Name = "uS_Ph_ValidityCheck1";
            this.uS_Ph_ValidityCheck1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_ValidityCheck1.TabIndex = 5;
            // 
            // uS_Ph_ModifyMedicine1
            // 
            this.uS_Ph_ModifyMedicine1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_ModifyMedicine1.Location = new System.Drawing.Point(0, 1);
            this.uS_Ph_ModifyMedicine1.Name = "uS_Ph_ModifyMedicine1";
            this.uS_Ph_ModifyMedicine1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_ModifyMedicine1.TabIndex = 4;
            // 
            // uS_Ph_ViewMedicines1
            // 
            this.uS_Ph_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uS_Ph_ViewMedicines1.Name = "uS_Ph_ViewMedicines1";
            this.uS_Ph_ViewMedicines1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_ViewMedicines1.TabIndex = 3;
            // 
            // uS_Ph_DashBord1
            // 
            this.uS_Ph_DashBord1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_DashBord1.Location = new System.Drawing.Point(0, 1);
            this.uS_Ph_DashBord1.Name = "uS_Ph_DashBord1";
            this.uS_Ph_DashBord1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_DashBord1.TabIndex = 2;
            // 
            // uS_Ph_AddMedicine1
            // 
            this.uS_Ph_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uS_Ph_AddMedicine1.Location = new System.Drawing.Point(1, 2);
            this.uS_Ph_AddMedicine1.Name = "uS_Ph_AddMedicine1";
            this.uS_Ph_AddMedicine1.Size = new System.Drawing.Size(859, 770);
            this.uS_Ph_AddMedicine1.TabIndex = 1;
            // 
            // frm_Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 733);
            this.Controls.Add(this.pnlDashBord);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pharmacist";
            this.Load += new System.EventHandler(this.frm_Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDashBord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashBord;
        private Guna.UI2.WinForms.Guna2Button btnLougOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMed;
        private Guna.UI2.WinForms.Guna2Button btnValidityMed;
        private Guna.UI2.WinForms.Guna2Button btnModifyMed;
        private Guna.UI2.WinForms.Guna2Button btnViewMed;
        private Guna.UI2.WinForms.Guna2Button btnAddMed;
        private System.Windows.Forms.Panel pnlDashBord;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Pharmacist_US.US_Ph_AddMedicine uS_Ph_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Pharmacist_US.US_Ph_DashBord uS_Ph_DashBord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Pharmacist_US.US_Ph_ViewMedicines uS_Ph_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Pharmacist_US.US_Ph_ModifyMedicine uS_Ph_ModifyMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Pharmacist_US.US_Ph_ValidityCheck uS_Ph_ValidityCheck1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Pharmacist_US.US_Ph_SellMedicine uS_Ph_SellMedicine1;
        private Guna.UI2.WinForms.Guna2Button btnPrintMedicine;
    }
}