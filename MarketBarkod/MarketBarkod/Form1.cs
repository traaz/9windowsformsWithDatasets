﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBarkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKategori adminCategoryPage= new AdminKategori();
            adminCategoryPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnMainPage adminProductPage = new btnMainPage();
            adminProductPage.Show();
        }
    }
}
