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
    public partial class uprbeg2 : Form
    {
        public uprbeg2()
        {
            InitializeComponent();
        }

        private void uprbeg2_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new sert().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new redpb().Show();
        }
    }
}
