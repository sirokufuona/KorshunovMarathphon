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
    public partial class menuadmin : Form
    {
        public menuadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuadmin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new uprblorg().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new valanter().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form login = new login();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }
    }
}
