namespace AppNIDIO.Components.Core
{
    partial class frmCfg
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gpbBtns = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbFor.SuspendLayout();
            this.gpbBtns.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.Location = new System.Drawing.Point(314, 42);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(80, 24);
            this.lblReq.TabIndex = 4;
            this.lblReq.Text = "Configs";
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
            this.gpbFor.Controls.Add(this.checkBox2);
            this.gpbFor.Controls.Add(this.checkBox1);
            this.gpbFor.Location = new System.Drawing.Point(12, 113);
            this.gpbFor.Name = "gpbFor";
            this.gpbFor.Size = new System.Drawing.Size(416, 103);
            this.gpbFor.TabIndex = 5;
            this.gpbFor.TabStop = false;
            this.gpbFor.Text = "Geral:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(206, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Atualização de eventos em tempo real";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Receber notificações";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gpbBtns
            // 
            this.gpbBtns.Controls.Add(this.btnSend);
            this.gpbBtns.Controls.Add(this.btnExit);
            this.gpbBtns.Location = new System.Drawing.Point(12, 482);
            this.gpbBtns.Name = "gpbBtns";
            this.gpbBtns.Size = new System.Drawing.Size(417, 57);
            this.gpbBtns.TabIndex = 7;
            this.gpbBtns.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(319, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Aplicar";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Voltar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.button2);
            this.gpbAddress.Controls.Add(this.textBox3);
            this.gpbAddress.Controls.Add(this.textBox2);
            this.gpbAddress.Controls.Add(this.textBox1);
            this.gpbAddress.Controls.Add(this.label5);
            this.gpbAddress.Controls.Add(this.label4);
            this.gpbAddress.Controls.Add(this.label3);
            this.gpbAddress.Location = new System.Drawing.Point(12, 222);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(417, 118);
            this.gpbAddress.TabIndex = 8;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Conexão:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Testar Conexão";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ultima verificação: 15/11/2018";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ultima atualização: 01/11/2018";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verificar agora";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(17, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(188, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Atualizar sistema automaticamente";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // frmCfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbAddress);
            this.Controls.Add(this.gpbBtns);
            this.Controls.Add(this.gpbFor);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCfg";
            this.Text = "Configs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbFor.ResumeLayout(false);
            this.gpbFor.PerformLayout();
            this.gpbBtns.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbFor;
        private System.Windows.Forms.GroupBox gpbBtns;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbAddress;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}