namespace Figurinha_Copa_2026
{
    partial class frmListaFigurinhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFigurinhas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpFigu = new System.Windows.Forms.FlowLayoutPanel();
            this.listaDeFigurinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbComum = new System.Windows.Forms.RadioButton();
            this.rbRara = new System.Windows.Forms.RadioButton();
            this.rbLendaria = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rbDesejada = new System.Windows.Forms.RadioButton();
            this.rbObtida = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.listaDeFigurinhasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurinhaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // figurinhaToolStripMenuItem
            // 
            this.figurinhaToolStripMenuItem.Name = "figurinhaToolStripMenuItem";
            this.figurinhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figurinhaToolStripMenuItem.Text = "Figurinha";
            this.figurinhaToolStripMenuItem.Click += new System.EventHandler(this.figurinhaToolStripMenuItem_Click);
            // 
            // flpFigu
            // 
            this.flpFigu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flpFigu.AutoScroll = true;
            this.flpFigu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpFigu.BackgroundImage = global::Figurinha_Copa_2026.Properties.Resources.campoFutebol_png;
            this.flpFigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpFigu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFigu.Location = new System.Drawing.Point(0, 182);
            this.flpFigu.Name = "flpFigu";
            this.flpFigu.Size = new System.Drawing.Size(800, 268);
            this.flpFigu.TabIndex = 1;
            // 
            // listaDeFigurinhasToolStripMenuItem
            // 
            this.listaDeFigurinhasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaListaToolStripMenuItem});
            this.listaDeFigurinhasToolStripMenuItem.Name = "listaDeFigurinhasToolStripMenuItem";
            this.listaDeFigurinhasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.listaDeFigurinhasToolStripMenuItem.Text = "Lista de Figurinhas";
            // 
            // minhaListaToolStripMenuItem
            // 
            this.minhaListaToolStripMenuItem.Name = "minhaListaToolStripMenuItem";
            this.minhaListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minhaListaToolStripMenuItem.Text = "Minha Lista";
            this.minhaListaToolStripMenuItem.Click += new System.EventHandler(this.minhaListaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbObtida);
            this.groupBox1.Controls.Add(this.rbDesejada);
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Controls.Add(this.rbLendaria);
            this.groupBox1.Controls.Add(this.rbRara);
            this.groupBox1.Controls.Add(this.rbComum);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(468, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // rbComum
            // 
            this.rbComum.AutoSize = true;
            this.rbComum.Location = new System.Drawing.Point(6, 13);
            this.rbComum.Name = "rbComum";
            this.rbComum.Size = new System.Drawing.Size(68, 19);
            this.rbComum.TabIndex = 0;
            this.rbComum.Text = "Comum";
            this.rbComum.UseVisualStyleBackColor = true;
            this.rbComum.CheckedChanged += new System.EventHandler(this.rbComum_CheckedChanged);
            // 
            // rbRara
            // 
            this.rbRara.AutoSize = true;
            this.rbRara.Location = new System.Drawing.Point(6, 38);
            this.rbRara.Name = "rbRara";
            this.rbRara.Size = new System.Drawing.Size(50, 19);
            this.rbRara.TabIndex = 1;
            this.rbRara.Text = "Rara";
            this.rbRara.UseVisualStyleBackColor = true;
            this.rbRara.CheckedChanged += new System.EventHandler(this.rbRara_CheckedChanged);
            // 
            // rbLendaria
            // 
            this.rbLendaria.AutoSize = true;
            this.rbLendaria.Location = new System.Drawing.Point(101, 13);
            this.rbLendaria.Name = "rbLendaria";
            this.rbLendaria.Size = new System.Drawing.Size(72, 19);
            this.rbLendaria.TabIndex = 2;
            this.rbLendaria.Text = "Lendaria";
            this.rbLendaria.UseVisualStyleBackColor = true;
            this.rbLendaria.CheckedChanged += new System.EventHandler(this.rbLendaria_CheckedChanged);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(101, 38);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(56, 19);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar por nome:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.ForeColor = System.Drawing.Color.LightGray;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 47);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(185, 20);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // rbDesejada
            // 
            this.rbDesejada.AutoSize = true;
            this.rbDesejada.Location = new System.Drawing.Point(199, 13);
            this.rbDesejada.Name = "rbDesejada";
            this.rbDesejada.Size = new System.Drawing.Size(80, 19);
            this.rbDesejada.TabIndex = 4;
            this.rbDesejada.Text = "Desejadas";
            this.rbDesejada.UseVisualStyleBackColor = true;
            this.rbDesejada.CheckedChanged += new System.EventHandler(this.rbDesejada_CheckedChanged);
            // 
            // rbObtida
            // 
            this.rbObtida.AutoSize = true;
            this.rbObtida.Location = new System.Drawing.Point(199, 36);
            this.rbObtida.Name = "rbObtida";
            this.rbObtida.Size = new System.Drawing.Size(67, 19);
            this.rbObtida.TabIndex = 5;
            this.rbObtida.Text = "Obtidas";
            this.rbObtida.UseVisualStyleBackColor = true;
            this.rbObtida.CheckedChanged += new System.EventHandler(this.rbObtida_CheckedChanged);
            // 
            // frmListaFigurinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Figurinha_Copa_2026.Properties.Resources.ImagemTime_jng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpFigu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaFigurinhas";
            this.Text = "frmListaFigurinhas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurinhaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpFigu;
        private System.Windows.Forms.ToolStripMenuItem listaDeFigurinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLendaria;
        private System.Windows.Forms.RadioButton rbRara;
        private System.Windows.Forms.RadioButton rbComum;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbObtida;
        private System.Windows.Forms.RadioButton rbDesejada;
    }
}