using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppNIDIO.Core;
using AppNIDIO.Components.Requisitar;

namespace AppNIDIO.Components.Menu
{
    public partial class frmMenu : Form
    {
        ModCore core;

        public frmMenu(ref ModCore core)
        {
            this.core = core;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            frmReq frm = new frmReq(ref this.core);
            frm.Show();
        }
    }
}
