namespace AppNIDIO.Components.Consultar
{
    partial class frmCons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReq = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbFor = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.txtSts = new System.Windows.Forms.TextBox();
            this.txtSrv = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSrv = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.gpbBtns = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbEvent = new System.Windows.Forms.GroupBox();
            this.ltbEvent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbFor.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.gpbBtns.SuspendLayout();
            this.gpbEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.Location = new System.Drawing.Point(760, 39);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(91, 24);
            this.lblReq.TabIndex = 4;
            this.lblReq.Text = "Consulta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppNIDIO.ResourceApp.logoVeto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gpbFor
            // 
            this.gpbFor.Controls.Add(this.lblEmail);
            this.gpbFor.Controls.Add(this.lblName);
            this.gpbFor.Controls.Add(this.txtEmail);
            this.gpbFor.Controls.Add(this.txtName);
            this.gpbFor.Location = new System.Drawing.Point(12, 113);
            this.gpbFor.Name = "gpbFor";
            this.gpbFor.Size = new System.Drawing.Size(417, 110);
            this.gpbFor.TabIndex = 5;
            this.gpbFor.TabStop = false;
            this.gpbFor.Text = "Requisitado por:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(19, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(73, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(73, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 24);
            this.txtName.TabIndex = 0;
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.txtSts);
            this.gpbInfo.Controls.Add(this.txtSrv);
            this.gpbInfo.Controls.Add(this.lblStatus);
            this.gpbInfo.Controls.Add(this.lblSrv);
            this.gpbInfo.Controls.Add(this.lblDesc);
            this.gpbInfo.Controls.Add(this.txtDesc);
            this.gpbInfo.Controls.Add(this.lblCod);
            this.gpbInfo.Controls.Add(this.txtCod);
            this.gpbInfo.Controls.Add(this.lblDate);
            this.gpbInfo.Controls.Add(this.txtDate);
            this.gpbInfo.Location = new System.Drawing.Point(12, 232);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(417, 244);
            this.gpbInfo.TabIndex = 6;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informações";
            // 
            // txtSts
            // 
            this.txtSts.Enabled = false;
            this.txtSts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSts.Location = new System.Drawing.Point(268, 78);
            this.txtSts.Name = "txtSts";
            this.txtSts.Size = new System.Drawing.Size(126, 24);
            this.txtSts.TabIndex = 12;
            // 
            // txtSrv
            // 
            this.txtSrv.Enabled = false;
            this.txtSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrv.Location = new System.Drawing.Point(82, 77);
            this.txtSrv.Name = "txtSrv";
            this.txtSrv.Size = new System.Drawing.Size(126, 24);
            this.txtSrv.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(214, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblSrv
            // 
            this.lblSrv.AutoSize = true;
            this.lblSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrv.Location = new System.Drawing.Point(19, 82);
            this.lblSrv.Name = "lblSrv";
            this.lblSrv.Size = new System.Drawing.Size(57, 16);
            this.lblSrv.TabIndex = 8;
            this.lblSrv.Text = "Serviço:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(19, 120);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(73, 16);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Descrição:";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(22, 139);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(372, 82);
            this.txtDesc.TabIndex = 6;
            this.txtDesc.Text = "Descreve sua requisição aqui...";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(19, 36);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(36, 16);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Cod:";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.Info;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(73, 31);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(93, 24);
            this.txtCod.TabIndex = 4;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(179, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Data:";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(225, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(169, 24);
            this.txtDate.TabIndex = 1;
            // 
            // gpbBtns
            // 
            this.gpbBtns.Controls.Add(this.btnExit);
            this.gpbBtns.Location = new System.Drawing.Point(12, 482);
            this.gpbBtns.Name = "gpbBtns";
            this.gpbBtns.Size = new System.Drawing.Size(848, 57);
            this.gpbBtns.TabIndex = 7;
            this.gpbBtns.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Cancelar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbEvent
            // 
            this.gpbEvent.Controls.Add(this.ltbEvent);
            this.gpbEvent.Location = new System.Drawing.Point(445, 113);
            this.gpbEvent.Name = "gpbEvent";
            this.gpbEvent.Size = new System.Drawing.Size(415, 363);
            this.gpbEvent.TabIndex = 8;
            this.gpbEvent.TabStop = false;
            this.gpbEvent.Text = "Eventos";
            // 
            // ltbEvent
            // 
            this.ltbEvent.Enabled = false;
            this.ltbEvent.FormattingEnabled = true;
            this.ltbEvent.Location = new System.Drawing.Point(6, 27);
            this.ltbEvent.MultiColumn = true;
            this.ltbEvent.Name = "ltbEvent";
            this.ltbEvent.Size = new System.Drawing.Size(400, 316);
            this.ltbEvent.TabIndex = 0;
            // 
            // frmCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 551);
            this.Controls.Add(this.gpbEvent);
            this.Controls.Add(this.gpbBtns);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbFor);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCons";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbFor.ResumeLayout(false);
            this.gpbFor.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbBtns.ResumeLayout(false);
            this.gpbEvent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbFor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox gpbBtns;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSrv;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gpbEvent;
        private System.Windows.Forms.ListBox ltbEvent;
        private System.Windows.Forms.TextBox txtSts;
        private System.Windows.Forms.TextBox txtSrv;
    }
}