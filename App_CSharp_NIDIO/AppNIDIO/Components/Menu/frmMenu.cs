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
using AppNIDIO.Components.Core;
using AppNIDIO.Components.Requisitar;
using AppNIDIO.Components.Consultar;
using AppNIDIO.Components.Cadastro;

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

        private void btnCons_Click(object sender, EventArgs e)
        {
            frmCons frm = new frmCons(ref this.core);
            frm.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            frmCad frm = new frmCad(ref this.core);
            frm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.Show();
        }

        private void btnCfg_Click(object sender, EventArgs e)
        {
            frmCfg frm = new frmCfg(ref this.core);
            frm.Show();
        }
    }
}
