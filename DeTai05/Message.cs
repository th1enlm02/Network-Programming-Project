﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai05
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            buttonOK.Focus();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
