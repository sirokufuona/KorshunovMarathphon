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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form map = new map();
            map.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form info = new info();
            info.Show();
        }
    }
}
