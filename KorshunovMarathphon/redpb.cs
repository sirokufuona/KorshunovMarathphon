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
    public partial class redpb : Form
    {
        public redpb()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new uprbeg2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }
    }
}
