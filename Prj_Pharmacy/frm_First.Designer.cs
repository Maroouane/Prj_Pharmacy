namespace Prj_Pharmacy
{
    partial class frm_First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_First));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Cp = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 1.0";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Cp
            // 
            this.Cp.animated = false;
            this.Cp.animationIterval = 5;
            this.Cp.animationSpeed = 300;
            this.Cp.BackColor = System.Drawing.Color.Cyan;
            this.Cp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cp.BackgroundImage")));
            this.Cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Cp.ForeColor = System.Drawing.Color.Black;
            this.Cp.LabelVisible = true;
            this.Cp.LineProgressThickness = 8;
            this.Cp.LineThickness = 5;
            this.Cp.Location = new System.Drawing.Point(134, 77);
            this.Cp.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Cp.MaxValue = 100;
            this.Cp.Name = "Cp";
            this.Cp.ProgressBackColor = System.Drawing.Color.Black;
            this.Cp.ProgressColor = System.Drawing.Color.Black;
            this.Cp.Size = new System.Drawing.Size(118, 118);
            this.Cp.TabIndex = 3;
            this.Cp.Value = 0;
            // 
            // frm_First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(386, 230);
            this.Controls.Add(this.Cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_First";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_First";
            this.Load += new System.EventHandler(this.frm_First_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Cp;
    }
}