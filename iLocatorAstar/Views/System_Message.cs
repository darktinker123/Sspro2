﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLocatorAstar
{
    public partial class System_Message : Form
    {
        public System_Message()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
