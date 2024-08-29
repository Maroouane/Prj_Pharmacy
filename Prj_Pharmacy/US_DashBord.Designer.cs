namespace Prj_Pharmacy
{
    partial class US_DashBord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_DashBord));
            this.label1 = new System.Windows.Forms.Label();
            this.gp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblNbAdmin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PnlPharmacy = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNbPharmacist = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNbCustomer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAdmin.SuspendLayout();
            this.PnlPharmacy.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashbord ";
            // 
            // gp
            // 
            this.gp.TargetControl = this;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAdmin.Controls.Add(this.lblNbAdmin);
            this.pnlAdmin.Controls.Add(this.label10);
            this.pnlAdmin.Controls.Add(this.label9);
            this.pnlAdmin.Controls.Add(this.label8);
            this.pnlAdmin.Controls.Add(this.label5);
            this.pnlAdmin.Location = new System.Drawing.Point(29, 152);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(232, 532);
            this.pnlAdmin.TabIndex = 1;
            // 
            // lblNbAdmin
            // 
            this.lblNbAdmin.AutoSize = true;
            this.lblNbAdmin.BackColor = System.Drawing.Color.White;
            this.lblNbAdmin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAdmin.Location = new System.Drawing.Point(98, 385);
            this.lblNbAdmin.Name = "lblNbAdmin";
            this.lblNbAdmin.Size = new System.Drawing.Size(14, 15);
            this.lblNbAdmin.TabIndex = 4;
            this.lblNbAdmin.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "All  Admin Users";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 135);
            this.label9.TabIndex = 2;
            this.label9.Text = "Admin is the role with the highist level\r\n of acces.\r\n\r\nAdmins can control a lot " +
    "of things like \r\nsettings etc.\r\n\r\nThey can add and delete other user \r\nadmins, t" +
    "hey can approve edits made\r\n by user.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 45);
            this.label8.TabIndex = 1;
            this.label8.Text = "-Add User\r\n-View User\r\n-Profile Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "His tasks:";
            // 
            // PnlPharmacy
            // 
            this.PnlPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnlPharmacy.Controls.Add(this.label16);
            this.PnlPharmacy.Controls.Add(this.lblNbPharmacist);
            this.PnlPharmacy.Controls.Add(this.label11);
            this.PnlPharmacy.Controls.Add(this.label6);
            this.PnlPharmacy.Location = new System.Drawing.Point(312, 152);
            this.PnlPharmacy.Name = "PnlPharmacy";
            this.PnlPharmacy.Size = new System.Drawing.Size(232, 532);
            this.PnlPharmacy.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 60);
            this.label16.TabIndex = 6;
            this.label16.Text = "-Add Medicines\r\n-View Medicines\r\n-Medicine Management\r\n-Sell Medicine";
            // 
            // lblNbPharmacist
            // 
            this.lblNbPharmacist.AutoSize = true;
            this.lblNbPharmacist.BackColor = System.Drawing.Color.White;
            this.lblNbPharmacist.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPharmacist.Location = new System.Drawing.Point(94, 385);
            this.lblNbPharmacist.Name = "lblNbPharmacist";
            this.lblNbPharmacist.Size = new System.Drawing.Size(14, 15);
            this.lblNbPharmacist.TabIndex = 5;
            this.lblNbPharmacist.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "All Pharmacists";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "His tasks:";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCustomer.Controls.Add(this.label17);
            this.pnlCustomer.Controls.Add(this.lblNbCustomer);
            this.pnlCustomer.Controls.Add(this.label12);
            this.pnlCustomer.Controls.Add(this.label7);
            this.pnlCustomer.Location = new System.Drawing.Point(605, 152);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(232, 532);
            this.pnlCustomer.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 60);
            this.label17.TabIndex = 7;
            this.label17.Text = "-Add Medicines\r\n-View Medicines\r\n-Medicine Management\r\n-Sell Medicine";
            // 
            // lblNbCustomer
            // 
            this.lblNbCustomer.AutoSize = true;
            this.lblNbCustomer.BackColor = System.Drawing.Color.White;
            this.lblNbCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbCustomer.Location = new System.Drawing.Point(99, 385);
            this.lblNbCustomer.Name = "lblNbCustomer";
            this.lblNbCustomer.Size = new System.Drawing.Size(14, 15);
            this.lblNbCustomer.TabIndex = 5;
            this.lblNbCustomer.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "All  Customers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "His tasks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pharmacist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer";
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
            this.btnRefresh.Location = new System.Drawing.Point(471, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(31, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // US_DashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.PnlPharmacy);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.label1);
            this.Name = "US_DashBord";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_DashBord_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.PnlPharmacy.ResumeLayout(false);
            this.PnlPharmacy.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse gp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNbCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PnlPharmacy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNbPharmacist;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblNbAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
