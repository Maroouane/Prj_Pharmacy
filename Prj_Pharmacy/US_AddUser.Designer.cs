namespace Prj_Pharmacy
{
    partial class US_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_AddUser));
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dtpDateBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.pbTrue = new System.Windows.Forms.PictureBox();
            this.pbFalse = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(444, 374);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(431, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(444, 299);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 20);
            this.txtUserName.TabIndex = 47;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Email Adresse";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(444, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(361, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 314);
            this.panel1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "Number Phone";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(71, 452);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(222, 20);
            this.txtNumber.TabIndex = 42;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.BorderThickness = 1;
            this.dtpDateBirth.CheckedState.Parent = this.dtpDateBirth;
            this.dtpDateBirth.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateBirth.HoverState.Parent = this.dtpDateBirth;
            this.dtpDateBirth.Location = new System.Drawing.Point(71, 374);
            this.dtpDateBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.ShadowDecoration.Parent = this.dtpDateBirth;
            this.dtpDateBirth.Size = new System.Drawing.Size(222, 20);
            this.dtpDateBirth.TabIndex = 41;
            this.dtpDateBirth.Value = new System.DateTime(2022, 2, 9, 16, 26, 14, 59);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 299);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "User Role";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(71, 219);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(222, 21);
            this.cmbUserRole.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add New User";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.BorderSize = 1;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(22, 22);
            this.btnReset.Location = new System.Drawing.Point(610, 453);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 18;
            this.btnReset.Size = new System.Drawing.Size(126, 36);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbTrue
            // 
            this.pbTrue.Image = ((System.Drawing.Image)(resources.GetObject("pbTrue.Image")));
            this.pbTrue.Location = new System.Drawing.Point(672, 297);
            this.pbTrue.Name = "pbTrue";
            this.pbTrue.Size = new System.Drawing.Size(25, 25);
            this.pbTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrue.TabIndex = 53;
            this.pbTrue.TabStop = false;
            // 
            // pbFalse
            // 
            this.pbFalse.Image = ((System.Drawing.Image)(resources.GetObject("pbFalse.Image")));
            this.pbFalse.Location = new System.Drawing.Point(703, 297);
            this.pbFalse.Name = "pbFalse";
            this.pbFalse.Size = new System.Drawing.Size(25, 25);
            this.pbFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFalse.TabIndex = 54;
            this.pbFalse.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AnimationHoverSpeed = 0.07F;
            this.btnSignUp.AnimationSpeed = 0.03F;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.BorderSize = 1;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
            this.btnSignUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUp.Location = new System.Drawing.Point(432, 453);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignUp.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.OnHoverImage = null;
            this.btnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUp.Radius = 18;
            this.btnSignUp.Size = new System.Drawing.Size(126, 36);
            this.btnSignUp.TabIndex = 51;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // US_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbFalse);
            this.Controls.Add(this.pbTrue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.label1);
            this.Name = "US_AddUser";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI.WinForms.GunaButton btnReset;
        private System.Windows.Forms.PictureBox pbTrue;
        private System.Windows.Forms.PictureBox pbFalse;
        private Guna.UI.WinForms.GunaButton btnSignUp;
    }
}
