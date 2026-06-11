namespace Figurinha_Copa_2026
{
    partial class frmMimFigu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMimFigu));
            this.flpMinhaFigu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFigurinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDaLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMinhaFigu
            // 
            this.flpMinhaFigu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMinhaFigu.BackgroundImage = global::Figurinha_Copa_2026.Properties.Resources.campoFutebol_png;
            this.flpMinhaFigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpMinhaFigu.Location = new System.Drawing.Point(-2, 221);
            this.flpMinhaFigu.Name = "flpMinhaFigu";
            this.flpMinhaFigu.Size = new System.Drawing.Size(804, 232);
            this.flpMinhaFigu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.listaDeFigurinhasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.iToolStripMenuItem.Text = "Início";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurinhasToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // figurinhasToolStripMenuItem
            // 
            this.figurinhasToolStripMenuItem.Name = "figurinhasToolStripMenuItem";
            this.figurinhasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.figurinhasToolStripMenuItem.Text = "Figurinhas";
            this.figurinhasToolStripMenuItem.Click += new System.EventHandler(this.figurinhasToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // listaDeFigurinhasToolStripMenuItem
            // 
            this.listaDeFigurinhasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDaLojaToolStripMenuItem});
            this.listaDeFigurinhasToolStripMenuItem.Name = "listaDeFigurinhasToolStripMenuItem";
            this.listaDeFigurinhasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.listaDeFigurinhasToolStripMenuItem.Text = "Lista de Figurinhas";
            // 
            // listaDaLojaToolStripMenuItem
            // 
            this.listaDaLojaToolStripMenuItem.Name = "listaDaLojaToolStripMenuItem";
            this.listaDaLojaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.listaDaLojaToolStripMenuItem.Text = "Lista da Loja";
            this.listaDaLojaToolStripMenuItem.Click += new System.EventHandler(this.listaDaLojaToolStripMenuItem_Click);
            // 
            // frmMimFigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Figurinha_Copa_2026.Properties.Resources.Captura_de_tela_9_6_2026_4347_www_bing_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpMinhaFigu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMimFigu";
            this.Text = "frmMimFigu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMinhaFigu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeFigurinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDaLojaToolStripMenuItem;
    }
}