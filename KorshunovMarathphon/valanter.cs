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
    public partial class valanter : Form
    {
        public valanter()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new menuadmin().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
