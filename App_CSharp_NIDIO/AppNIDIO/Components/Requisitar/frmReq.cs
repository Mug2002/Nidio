using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNIDIO.Components.Requisitar
{
    public partial class frmReq : Form
    {
        public frmReq()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtCod.Clear();
            this.txtDate.Clear();
            this.txtDesc.Clear();
            this.txtEmail.Clear();
            this.txtName.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}
