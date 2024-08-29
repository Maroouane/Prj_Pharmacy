namespace Prj_Pharmacy.Pharmacist_US
{
    partial class US_Ph_AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Ph_AddMedicine));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.dtpManufacturing = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpire = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(329, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Medicine";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(118, 207);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(222, 20);
            this.txtCode.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 291);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 42;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(118, 380);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(222, 20);
            this.txtNumber.TabIndex = 44;
            // 
            // dtpManufacturing
            // 
            this.dtpManufacturing.BorderThickness = 1;
            this.dtpManufacturing.CheckedState.Parent = this.dtpManufacturing;
            this.dtpManufacturing.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpManufacturing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpManufacturing.HoverState.Parent = this.dtpManufacturing;
            this.dtpManufacturing.Location = new System.Drawing.Point(118, 459);
            this.dtpManufacturing.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpManufacturing.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpManufacturing.Name = "dtpManufacturing";
            this.dtpManufacturing.ShadowDecoration.Parent = this.dtpManufacturing;
            this.dtpManufacturing.Size = new System.Drawing.Size(222, 20);
            this.dtpManufacturing.TabIndex = 48;
            this.dtpManufacturing.Value = new System.DateTime(2022, 2, 9, 16, 26, 14, 59);
            // 
            // dtpExpire
            // 
            this.dtpExpire.BorderThickness = 1;
            this.dtpExpire.CheckedState.Parent = this.dtpExpire;
            this.dtpExpire.FillColor = System.Drawing.Color.DodgerBlue;
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExpire.HoverState.Parent = this.dtpExpire;
            this.dtpExpire.Location = new System.Drawing.Point(512, 207);
            this.dtpExpire.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpire.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.ShadowDecoration.Parent = this.dtpExpire;
            this.dtpExpire.Size = new System.Drawing.Size(222, 20);
            this.dtpExpire.TabIndex = 50;
            this.dtpExpire.Value = new System.DateTime(2022, 2, 9, 16, 26, 14, 59);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(512, 291);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(222, 20);
            this.txtQuantity.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(512, 380);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(222, 20);
            this.txtPrice.TabIndex = 53;
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
            this.btnReset.ImageSize = new System.Drawing.Size(24, 24);
            this.btnReset.Location = new System.Drawing.Point(451, 570);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 18;
            this.btnReset.Size = new System.Drawing.Size(113, 36);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(317, 570);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 18;
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(428, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 314);
            this.panel1.TabIndex = 57;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(115, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Medicine Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(115, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(115, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Medicine Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(115, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Manufacturing Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(509, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(509, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 64;
            this.label11.Text = "Expire Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(509, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 65;
            this.label12.Text = "Price per Unit";
            // 
            // US_Ph_AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtpExpire);
            this.Controls.Add(this.dtpManufacturing);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "US_Ph_AddMedicine";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_Ph_AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpManufacturing;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpire;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
