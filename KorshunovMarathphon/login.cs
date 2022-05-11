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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e) //скрытие панели
        {
            panel3.Visible = !panel3.Visible;
        }

        private void button2_Click(object sender, EventArgs e) //открытие панели
        {
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            Hide();
            new mainscreen().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menukoord = new menukoord();
            menukoord.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form menuadmin = new menuadmin();
            menuadmin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new menu().Show();
        }
    }
}
