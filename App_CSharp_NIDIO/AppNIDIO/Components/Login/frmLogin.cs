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

namespace AppNIDIO.Components.Login
{
    public partial class frmLogin : Form
    {
        private modLogin control = new modLogin();

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

            //bool response = control.login(userName, userPass);

            if (userName == "joseph" && userPass == "123")
            {
                frmMenu frm = new frmMenu();
                frm.Show();
            } else
            {
                MessageBox.Show("Usuario ou Senha incorretos!");
            }

            //MessageBox.Show("Response: " + response.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear();
            this.txtPass.Clear();
            this.Close();
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
