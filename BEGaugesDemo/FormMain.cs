﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEGaugesDemo.CircularGauges;

namespace BEGaugesDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void _btnClockControl_Click(object sender, EventArgs e)
        {
            var form = new ClockForm();
            form.Show(this);
        }
    }
}
