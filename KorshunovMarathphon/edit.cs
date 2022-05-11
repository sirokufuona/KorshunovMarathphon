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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
