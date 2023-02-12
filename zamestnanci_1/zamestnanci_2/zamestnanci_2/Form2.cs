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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btn_ukazatzam_Click(object sender, EventArgs e)
        {
            string path = "FilesWorkers.txt";
            string texty = File.ReadAllText(path);
            lbl_vypiszamest.Text = texty;
        }

        private void btn_zpet2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1= new Form1();
            f1.Show();
        }
    }
}
