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
    public partial class zagval : Form
    {
        public zagval()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new valanter().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new valanter().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new valanter().Show();
        }
    }
}
