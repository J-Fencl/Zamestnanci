namespace zamestnanci_2
{
    partial class Form3
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
            this.btn_ulozit = new System.Windows.Forms.Button();
            this.lbl_jmeno = new System.Windows.Forms.Label();
            this.lbl_bydliste = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.box_jmeno = new System.Windows.Forms.TextBox();
            this.box_bydliste = new System.Windows.Forms.TextBox();
            this.box_cislo = new System.Windows.Forms.TextBox();
            this.btn_zpet1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ulozit
            // 
            this.btn_ulozit.Location = new System.Drawing.Point(182, 309);
            this.btn_ulozit.Name = "btn_ulozit";
            this.btn_ulozit.Size = new System.Drawing.Size(136, 62);
            this.btn_ulozit.TabIndex = 0;
            this.btn_ulozit.Text = "Uložit";
            this.btn_ulozit.UseVisualStyleBackColor = true;
            this.btn_ulozit.Click += new System.EventHandler(this.btn_ulozit_Click);
            // 
            // lbl_jmeno
            // 
            this.lbl_jmeno.AutoSize = true;
            this.lbl_jmeno.Location = new System.Drawing.Point(203, 47);
            this.lbl_jmeno.Name = "lbl_jmeno";
            this.lbl_jmeno.Size = new System.Drawing.Size(98, 15);
            this.lbl_jmeno.TabIndex = 1;
            this.lbl_jmeno.Text = "Jméno a příjmení";
            // 
            // lbl_bydliste
            // 
            this.lbl_bydliste.AutoSize = true;
            this.lbl_bydliste.Location = new System.Drawing.Point(223, 133);
            this.lbl_bydliste.Name = "lbl_bydliste";
            this.lbl_bydliste.Size = new System.Drawing.Size(48, 15);
            this.lbl_bydliste.TabIndex = 2;
            this.lbl_bydliste.Text = "Bydliště";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(203, 225);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(82, 15);
            this.lbl_telefon.TabIndex = 3;
            this.lbl_telefon.Text = "Telefonní číslo";
            // 
            // box_jmeno
            // 
            this.box_jmeno.Location = new System.Drawing.Point(173, 79);
            this.box_jmeno.Name = "box_jmeno";
            this.box_jmeno.Size = new System.Drawing.Size(155, 23);
            this.box_jmeno.TabIndex = 4;
            // 
            // box_bydliste
            // 
            this.box_bydliste.Location = new System.Drawing.Point(173, 173);
            this.box_bydliste.Name = "box_bydliste";
            this.box_bydliste.Size = new System.Drawing.Size(155, 23);
            this.box_bydliste.TabIndex = 5;
            this.box_bydliste.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // box_cislo
            // 
            this.box_cislo.Location = new System.Drawing.Point(173, 257);
            this.box_cislo.Name = "box_cislo";
            this.box_cislo.Size = new System.Drawing.Size(155, 23);
            this.box_cislo.TabIndex = 6;
            // 
            // btn_zpet1
            // 
            this.btn_zpet1.Location = new System.Drawing.Point(12, 17);
            this.btn_zpet1.Name = "btn_zpet1";
            this.btn_zpet1.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet1.TabIndex = 7;
            this.btn_zpet1.Text = "Zpět";
            this.btn_zpet1.UseVisualStyleBackColor = true;
            this.btn_zpet1.Click += new System.EventHandler(this.btn_zpet1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 424);
            this.Controls.Add(this.btn_zpet1);
            this.Controls.Add(this.box_cislo);
            this.Controls.Add(this.box_bydliste);
            this.Controls.Add(this.box_jmeno);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_bydliste);
            this.Controls.Add(this.lbl_jmeno);
            this.Controls.Add(this.btn_ulozit);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ulozit;
        private Label lbl_jmeno;
        private Label lbl_bydliste;
        private Label lbl_telefon;
        private TextBox box_jmeno;
        private TextBox box_bydliste;
        private TextBox box_cislo;
        private Button btn_zpet1;
    }
}