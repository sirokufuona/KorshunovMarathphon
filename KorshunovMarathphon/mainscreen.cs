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
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //переход к авторизации
        {
            Hide();
            Form login = new login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Proverka = new Proverka();
            Proverka.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form spon = new spon();
            spon.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form info = new info();
            info.Show();
        }
    }
}
