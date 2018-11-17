namespace AppNIDIO.Components.Menu
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.Label();
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCons = new System.Windows.Forms.Label();
            this.lblReq = new System.Windows.Forms.Label();
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblCfg = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCfg = new System.Windows.Forms.Button();
            this.btnReq = new System.Windows.Forms.Button();
            this.btnCons = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbMain.SuspendLayout();
            this.gpbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(743, 42);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // gpbMain
            // 
            this.gpbMain.Controls.Add(this.label1);
            this.gpbMain.Controls.Add(this.lblCons);
            this.gpbMain.Controls.Add(this.lblReq);
            this.gpbMain.Controls.Add(this.btnReq);
            this.gpbMain.Controls.Add(this.btnCons);
            this.gpbMain.Controls.Add(this.btnCad);
            this.gpbMain.Location = new System.Drawing.Point(12, 109);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(395, 168);
            this.gpbMain.TabIndex = 6;
            this.gpbMain.TabStop = false;
            this.gpbMain.Text = "Principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro";
            // 
            // lblCons
            // 
            this.lblCons.AutoSize = true;
            this.lblCons.Location = new System.Drawing.Point(169, 132);
            this.lblCons.Name = "lblCons";
            this.lblCons.Size = new System.Drawing.Size(51, 13);
            this.lblCons.TabIndex = 2;
            this.lblCons.Text = "Consultar";
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Location = new System.Drawing.Point(46, 132);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(54, 13);
            this.lblReq.TabIndex = 1;
            this.lblReq.Text = "Requisitar";
            // 
            // gpbOptions
            // 
            this.gpbOptions.Controls.Add(this.lblExit);
            this.gpbOptions.Controls.Add(this.btnExit);
            this.gpbOptions.Controls.Add(this.lblCfg);
            this.gpbOptions.Controls.Add(this.btnInfo);
            this.gpbOptions.Controls.Add(this.lblInfo);
            this.gpbOptions.Controls.Add(this.btnCfg);
            this.gpbOptions.Location = new System.Drawing.Point(422, 109);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(395, 168);
            this.gpbOptions.TabIndex = 7;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Opções";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(303, 132);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 13);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Sair";
            // 
            // lblCfg
            // 
            this.lblCfg.AutoSize = true;
            this.lblCfg.Location = new System.Drawing.Point(175, 132);
            this.lblCfg.Name = "lblCfg";
            this.lblCfg.Size = new System.Drawing.Size(42, 13);
            this.lblCfg.TabIndex = 9;
            this.lblCfg.Text = "Configs";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(57, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Sobre";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::AppNIDIO.ResourceApp.exit;
            this.btnExit.Location = new System.Drawing.Point(267, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 94);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::AppNIDIO.ResourceApp.Utilities_System_Information_icon;
            this.btnInfo.Location = new System.Drawing.Point(29, 35);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(96, 94);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCfg
            // 
            this.btnCfg.Image = global::AppNIDIO.ResourceApp.unnamed;
            this.btnCfg.Location = new System.Drawing.Point(148, 35);
            this.btnCfg.Name = "btnCfg";
            this.btnCfg.Size = new System.Drawing.Size(96, 94);
            this.btnCfg.TabIndex = 4;
            this.btnCfg.UseVisualStyleBackColor = true;
            this.btnCfg.Click += new System.EventHandler(this.btnCfg_Click);
            // 
            // btnReq
            // 
            this.btnReq.Image = global::AppNIDIO.ResourceApp.register;
            this.btnReq.Location = new System.Drawing.Point(26, 35);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(96, 94);
            this.btnReq.TabIndex = 0;
            this.btnReq.UseVisualStyleBackColor = true;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // btnCons
            // 
            this.btnCons.Image = global::AppNIDIO.ResourceApp.analyze;
            this.btnCons.Location = new System.Drawing.Point(149, 35);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(96, 94);
            this.btnCons.TabIndex = 1;
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // btnCad
            // 
            this.btnCad.Image = global::AppNIDIO.ResourceApp.flat_icon_gestao_financeira;
            this.btnCad.Location = new System.Drawing.Point(268, 35);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(96, 94);
            this.btnCad.TabIndex = 2;
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppNIDIO.ResourceApp.logoVeto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 291);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.gpbMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCfg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCons;
        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblCfg;
        private System.Windows.Forms.Label lblInfo;
    }
}

