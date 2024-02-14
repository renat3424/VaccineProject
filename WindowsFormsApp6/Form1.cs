using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fffffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ffffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f = new Form3();
            




            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void больницаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.mainForm = this;




            f.Show();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            




            f.Show();
        }

        private void пациентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();





            f.Show();
        }
    }
}
