using System;
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

namespace AppNIDIO.Components.Requisitar
{
    public partial class frmReq : Form
    {
        ModCore core; 

        public frmReq(ref ModCore core)
        {
            this.core = core;
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
            Req req = new Req();
            req.Service.Id = int.Parse(this.cmbSrv.SelectedValue.ToString());
            req.Service.Desc = this.cmbSrv.SelectedItem.ToString();
            req.Descricao = this.txtDesc.Text;

            int id;

            try {
                id = this.core.requisitar(req);

                MessageBox.Show("Requisição realizada com sucesso! Seu ID é o " + id + ".");
            } catch
            {
                MessageBox.Show("Erro ao tentar realizar requisição! Tente novamente.");
            }
        }

        private void frmReq_Load(object sender, EventArgs e)
        {
            List<Select> result = core.getServicos();

            foreach (Select item in result)
            {
                this.cmbSrv.Items.Add(item);
            }
        }
    }
}
