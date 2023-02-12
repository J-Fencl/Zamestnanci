using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zamestnanci_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ulozit_Click(object sender, EventArgs e)
        {
            using (StreamWriter napsat = new StreamWriter("FilesWorkers.txt", true)) //Odkaz by byl do složky
            {
                napsat.WriteLine(box_jmeno.Text +" - "+ box_bydliste.Text+" - " + box_cislo.Text);
                
                napsat.Close();
            }
            MessageBox.Show("Uloženo");
            box_jmeno.Clear();
            box_bydliste.Clear();
            box_cislo.Clear();
            
            
        }

        private void btn_zpet1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
