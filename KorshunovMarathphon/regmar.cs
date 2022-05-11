using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorshunovMarathphon
{
    public partial class regmar : Form
    {
        public regmar()
        {
            InitializeComponent();
            panel3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new menu().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            Hide();
            new menu().Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form podregbeg = new podregbeg();
            podregbeg.Show();
        }
    }
}
