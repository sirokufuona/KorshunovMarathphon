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
    public partial class myspon : Form
    {
        public myspon()
        {
            InitializeComponent();
        }

        private void myspon_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
