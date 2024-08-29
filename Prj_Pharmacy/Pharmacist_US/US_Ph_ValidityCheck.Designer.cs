namespace Prj_Pharmacy.Pharmacist_US
{
    partial class US_Ph_ValidityCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMedicines = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblMedicinesState = new System.Windows.Forms.Label();
            this.btnPrintMedicines = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(264, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "Check Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(217, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 36);
            this.label3.TabIndex = 66;
            this.label3.Text = "Medicine Validity Check";
            // 
            // dgvMedicines
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicines.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicines.EnableHeadersVisualStyles = false;
            this.dgvMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicines.Location = new System.Drawing.Point(38, 303);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(779, 332);
            this.dgvMedicines.TabIndex = 64;
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
            // 
            // cmbCheck
            // 
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Location = new System.Drawing.Point(380, 179);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(121, 21);
            this.cmbCheck.TabIndex = 68;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.cmbCheck_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblMedicinesState
            // 
            this.lblMedicinesState.AutoSize = true;
            this.lblMedicinesState.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicinesState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMedicinesState.Location = new System.Drawing.Point(46, 259);
            this.lblMedicinesState.Name = "lblMedicinesState";
            this.lblMedicinesState.Size = new System.Drawing.Size(134, 23);
            this.lblMedicinesState.TabIndex = 69;
            this.lblMedicinesState.Text = "All Medicines";
            // 
            // btnPrintMedicines
            // 
            this.btnPrintMedicines.AnimationHoverSpeed = 0.07F;
            this.btnPrintMedicines.AnimationSpeed = 0.03F;
            this.btnPrintMedicines.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintMedicines.BaseColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintMedicines.BorderColor = System.Drawing.Color.Black;
            this.btnPrintMedicines.BorderSize = 1;
            this.btnPrintMedicines.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintMedicines.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintMedicines.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMedicines.ForeColor = System.Drawing.Color.White;
            this.btnPrintMedicines.Image = null;
            this.btnPrintMedicines.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrintMedicines.Location = new System.Drawing.Point(351, 662);
            this.btnPrintMedicines.Name = "btnPrintMedicines";
            this.btnPrintMedicines.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPrintMedicines.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintMedicines.OnHoverForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintMedicines.OnHoverImage = null;
            this.btnPrintMedicines.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintMedicines.Radius = 18;
            this.btnPrintMedicines.Size = new System.Drawing.Size(113, 36);
            this.btnPrintMedicines.TabIndex = 70;
            this.btnPrintMedicines.Text = "Print ";
            this.btnPrintMedicines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintMedicines.Click += new System.EventHandler(this.btnPrintMedicines_Click);
            // 
            // US_Ph_ValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrintMedicines);
            this.Controls.Add(this.lblMedicinesState);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMedicines);
            this.Name = "US_Ph_ValidityCheck";
            this.Size = new System.Drawing.Size(859, 770);
            this.Load += new System.EventHandler(this.US_Ph_ValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicines;
        private System.Windows.Forms.ComboBox cmbCheck;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblMedicinesState;
        private Guna.UI.WinForms.GunaButton btnPrintMedicines;
    }
}
