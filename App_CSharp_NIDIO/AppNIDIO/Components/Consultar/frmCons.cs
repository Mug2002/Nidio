﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppNIDIO.Classes;
using AppNIDIO.Core;

namespace AppNIDIO.Components.Consultar
{
    public partial class frmCons : Form
    {
        ModCore core;

        public frmCons(ref ModCore core)
        {
            this.core = core;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
            }
        }
    }
}