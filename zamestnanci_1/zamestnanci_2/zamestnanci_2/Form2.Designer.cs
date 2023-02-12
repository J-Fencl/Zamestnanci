namespace zamestnanci_2
{
    partial class Form2
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
            this.lbl_vypiszamest = new System.Windows.Forms.Label();
            this.btn_ukazatzam = new System.Windows.Forms.Button();
            this.btn_zpet2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vypiszamest
            // 
            this.lbl_vypiszamest.AutoSize = true;
            this.lbl_vypiszamest.Location = new System.Drawing.Point(174, 61);
            this.lbl_vypiszamest.Name = "lbl_vypiszamest";
            this.lbl_vypiszamest.Size = new System.Drawing.Size(0, 15);
            this.lbl_vypiszamest.TabIndex = 1;
            // 
            // btn_ukazatzam
            // 
            this.btn_ukazatzam.Location = new System.Drawing.Point(121, 26);
            this.btn_ukazatzam.Name = "btn_ukazatzam";
            this.btn_ukazatzam.Size = new System.Drawing.Size(219, 23);
            this.btn_ukazatzam.TabIndex = 2;
            this.btn_ukazatzam.Text = "Vypsat zaměstnance";
            this.btn_ukazatzam.UseVisualStyleBackColor = true;
            this.btn_ukazatzam.Click += new System.EventHandler(this.btn_ukazatzam_Click);
            // 
            // btn_zpet2
            // 
            this.btn_zpet2.Location = new System.Drawing.Point(15, 16);
            this.btn_zpet2.Name = "btn_zpet2";
            this.btn_zpet2.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet2.TabIndex = 3;
            this.btn_zpet2.Text = "Zpět";
            this.btn_zpet2.UseVisualStyleBackColor = true;
            this.btn_zpet2.Click += new System.EventHandler(this.btn_zpet2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.btn_zpet2);
            this.Controls.Add(this.btn_ukazatzam);
            this.Controls.Add(this.lbl_vypiszamest);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_vypiszamest;
        private Button btn_ukazatzam;
        private Button btn_zpet2;
    }
}