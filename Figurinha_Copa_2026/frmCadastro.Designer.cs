namespace Figurinha_Copa_2026
{
    partial class frmCadastroFigurinhas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDesejada = new System.Windows.Forms.RadioButton();
            this.rbObtida = new System.Windows.Forms.RadioButton();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRara = new System.Windows.Forms.RadioButton();
            this.rbComum = new System.Windows.Forms.RadioButton();
            this.rbLendaria = new System.Windows.Forms.RadioButton();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFigurinha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFigurinha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRemoverImagem = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFigurinha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtDiretorio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSelecao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeFigurinha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(719, 81);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 29);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Selecionar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDesejada);
            this.groupBox3.Controls.Add(this.rbObtida);
            this.groupBox3.Location = new System.Drawing.Point(435, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 105);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status da figurinha:";
            // 
            // rbDesejada
            // 
            this.rbDesejada.AutoSize = true;
            this.rbDesejada.Location = new System.Drawing.Point(6, 48);
            this.rbDesejada.Name = "rbDesejada";
            this.rbDesejada.Size = new System.Drawing.Size(82, 21);
            this.rbDesejada.TabIndex = 6;
            this.rbDesejada.TabStop = true;
            this.rbDesejada.Text = "Desejada";
            this.rbDesejada.UseVisualStyleBackColor = true;
            // 
            // rbObtida
            // 
            this.rbObtida.AutoSize = true;
            this.rbObtida.Location = new System.Drawing.Point(121, 48);
            this.rbObtida.Name = "rbObtida";
            this.rbObtida.Size = new System.Drawing.Size(68, 21);
            this.rbObtida.TabIndex = 5;
            this.rbObtida.TabStop = true;
            this.rbObtida.Text = "Obtida";
            this.rbObtida.UseVisualStyleBackColor = true;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Enabled = false;
            this.txtDiretorio.Location = new System.Drawing.Point(435, 83);
            this.txtDiretorio.Multiline = true;
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(278, 18);
            this.txtDiretorio.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diretório:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRara);
            this.groupBox2.Controls.Add(this.rbComum);
            this.groupBox2.Controls.Add(this.rbLendaria);
            this.groupBox2.Location = new System.Drawing.Point(52, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione a raride da figurinha:";
            // 
            // rbRara
            // 
            this.rbRara.AutoSize = true;
            this.rbRara.Location = new System.Drawing.Point(6, 63);
            this.rbRara.Name = "rbRara";
            this.rbRara.Size = new System.Drawing.Size(53, 21);
            this.rbRara.TabIndex = 5;
            this.rbRara.TabStop = true;
            this.rbRara.Text = "Rara";
            this.rbRara.UseVisualStyleBackColor = true;
            // 
            // rbComum
            // 
            this.rbComum.AutoSize = true;
            this.rbComum.Location = new System.Drawing.Point(6, 36);
            this.rbComum.Name = "rbComum";
            this.rbComum.Size = new System.Drawing.Size(74, 21);
            this.rbComum.TabIndex = 4;
            this.rbComum.TabStop = true;
            this.rbComum.Text = "Comum";
            this.rbComum.UseVisualStyleBackColor = true;
            // 
            // rbLendaria
            // 
            this.rbLendaria.AutoSize = true;
            this.rbLendaria.Location = new System.Drawing.Point(6, 99);
            this.rbLendaria.Name = "rbLendaria";
            this.rbLendaria.Size = new System.Drawing.Size(79, 21);
            this.rbLendaria.TabIndex = 6;
            this.rbLendaria.TabStop = true;
            this.rbLendaria.Text = "Lendária";
            this.rbLendaria.UseVisualStyleBackColor = true;
            // 
            // txtSelecao
            // 
            this.txtSelecao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelecao.Location = new System.Drawing.Point(435, 39);
            this.txtSelecao.Multiline = true;
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(278, 18);
            this.txtSelecao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleção:";
            // 
            // txtNomeFigurinha
            // 
            this.txtNomeFigurinha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFigurinha.Location = new System.Drawing.Point(52, 39);
            this.txtNomeFigurinha.Multiline = true;
            this.txtNomeFigurinha.Name = "txtNomeFigurinha";
            this.txtNomeFigurinha.Size = new System.Drawing.Size(278, 18);
            this.txtNomeFigurinha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da figurinha:";
            // 
            // picFigurinha
            // 
            this.picFigurinha.Location = new System.Drawing.Point(12, 254);
            this.picFigurinha.Name = "picFigurinha";
            this.picFigurinha.Size = new System.Drawing.Size(776, 283);
            this.picFigurinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFigurinha.TabIndex = 1;
            this.picFigurinha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prévia da figurinha:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Silver;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(713, 223);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemoverImagem
            // 
            this.btnRemoverImagem.BackColor = System.Drawing.Color.Silver;
            this.btnRemoverImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverImagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverImagem.Location = new System.Drawing.Point(15, 543);
            this.btnRemoverImagem.Name = "btnRemoverImagem";
            this.btnRemoverImagem.Size = new System.Drawing.Size(102, 23);
            this.btnRemoverImagem.TabIndex = 4;
            this.btnRemoverImagem.Text = "Remover Imagem";
            this.btnRemoverImagem.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(713, 543);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCadastroFigurinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Figurinha_Copa_2026.Properties.Resources.pngtree_strong_lights_football_field_background_image_414453;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnRemoverImagem);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFigurinha);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroFigurinhas";
            this.Text = "frmCadastroFigurinha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFigurinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picFigurinha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFigurinha;
        private System.Windows.Forms.RadioButton rbLendaria;
        private System.Windows.Forms.RadioButton rbRara;
        private System.Windows.Forms.RadioButton rbComum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRemoverImagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDesejada;
        private System.Windows.Forms.RadioButton rbObtida;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}