namespace zamestnanci_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vypsat = new System.Windows.Forms.Button();
            this.btn_zapsat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vítej v seznamu zaměstnanců";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_vypsat
            // 
            this.btn_vypsat.Location = new System.Drawing.Point(52, 224);
            this.btn_vypsat.Name = "btn_vypsat";
            this.btn_vypsat.Size = new System.Drawing.Size(144, 40);
            this.btn_vypsat.TabIndex = 1;
            this.btn_vypsat.Text = "Vypsat ";
            this.btn_vypsat.UseCompatibleTextRendering = true;
            this.btn_vypsat.UseVisualStyleBackColor = true;
            this.btn_vypsat.Click += new System.EventHandler(this.btn_vypsat_Click);
            // 
            // btn_zapsat
            // 
            this.btn_zapsat.Location = new System.Drawing.Point(296, 224);
            this.btn_zapsat.Name = "btn_zapsat";
            this.btn_zapsat.Size = new System.Drawing.Size(142, 40);
            this.btn_zapsat.TabIndex = 2;
            this.btn_zapsat.Text = "Zapsat";
            this.btn_zapsat.UseVisualStyleBackColor = true;
            this.btn_zapsat.Click += new System.EventHandler(this.btn_zapsat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chcete vypsat zaměstnance, nebo zapsat nové?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_zapsat);
            this.Controls.Add(this.btn_vypsat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_vypsat;
        private Button btn_zapsat;
        private Label label2;
    }
}