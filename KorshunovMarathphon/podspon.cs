﻿using System;
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
    public partial class podspon : Form
    {
        public podspon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }
    }
}
