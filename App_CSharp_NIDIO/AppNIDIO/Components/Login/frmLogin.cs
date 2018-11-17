using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppNIDIO.Components.Menu;
using AppNIDIO.Core;

namespace AppNIDIO.Components.Login
{
    public partial class frmLogin : Form
    {
        private ModCore core = new ModCore();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUser.Text;
            string userPass = this.txtPass.Text;

            if (userName == "" || userPass == "")
            {
                MessageBox.Show("Usuario ou Senha em branco!");
                return;
            }

            //bool response = core.login(userName, userPass);

            //if (response)
            if (userName == "joseph" && userPass == "123")
            {
                frmMenu frm = new frmMenu(ref this.core);
                frm.Show();
            } else
            {
                MessageBox.Show("Usuario ou Senha incorretos!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.Close();
            Application.Exit();
        }

        private void chbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbPass.Checked)
            {
                this.txtPass.PasswordChar = '\0';
            } else
            {
                this.txtPass.PasswordChar = '*';
            }
        }
    }
}
