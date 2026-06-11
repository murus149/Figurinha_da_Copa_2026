using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Figurinha_Copa_2026.frmCadastroFigurinhas;
using static System.Net.Mime.MediaTypeNames;

namespace Figurinha_Copa_2026
{
    public partial class frmListaFigurinhas : Form
    {
        // Esta lista é estática, ou seja, ela guarda as figurinhas para sempre enquanto o app rodar
        public static List<Figurinha> AlbumGeral = new List<Figurinha>();


        
        public frmListaFigurinhas()
        {
            InitializeComponent();
            // Garantias mínimas caso Designer não tenha ajustado alguma propriedade visual
            if (flpFigu != null)
            {
                flpFigu.AutoScroll = true;
                flpFigu.WrapContents = true;
                flpFigu.FlowDirection = FlowDirection.LeftToRight;
            }

            this.Shown += frmListaFigurinhas_Shown;
          
        }

        //Image _image;
        //string _raridade;
        
        //public frmListaFigurinhas(Image imagemRecebida, string raridade, string status)
        //{
          //  InitializeComponent();
            //CorRaridade(raridade);
            //paginaCompleta(imagemRecebida, raridade);

            //_image = imagemRecebida;
            //_raridade = raridade;
           
        //}

        void CorRaridade(string raridade)
        {
            switch(raridade)
            {
                case "Comum":
                    this.BackColor = Color.LightGray;
                    break;
                case "Rara":
                    this.BackColor = Color.LightBlue;
                    break;
                case "Lendaria":
                    this.BackColor = Color.Gold;
                    break;

            }
        }

        private void frmListaFigurinhas_Shown(object sender, EventArgs e)
        {
            // if(_image == null)
            //{
            //   MessageBox.Show("uuuullll");
            //  return;
            //}
            DiagnosticoAlbum();
            LimparFlow();
            Filtrar();
        }
            
            
        


        void paginaCompleta(System.Drawing.Image imagem, string nome, string raridade, Figurinha objetoFigurinha)
        {
            CorRaridade(raridade);
           

            Panel pianel = new Panel();
            pianel.Size = new Size(120, 120);
            pianel.BorderStyle = BorderStyle.FixedSingle;
            pianel.BackColor = this.BackColor;

            Label lbl = new Label();
            lbl.Text = nome;        
            lbl.BackColor = Color.Transparent;
            lbl.Location = new Point(5, 5);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            

            PictureBox picFiguDesti = new PictureBox();
            picFiguDesti.Size = new Size(100, 100);
            picFiguDesti.Location = new Point(10, 20);
            picFiguDesti.SizeMode = PictureBoxSizeMode.StretchImage;
            picFiguDesti.Image = imagem != null ? new Bitmap(imagem) : SystemIcons.Warning.ToBitmap();
            picFiguDesti.Tag = objetoFigurinha;

            //Botões
            Button btnDesejado = new Button();
            btnDesejado.Text = "♥";
            btnDesejado.FlatStyle = FlatStyle.Flat;
            btnDesejado.FlatAppearance.BorderSize = 1;
            btnDesejado.FlatAppearance.BorderColor = Color.DimGray;
            btnDesejado.BackColor = Color.LightGreen;
            //btnDesejado.Location = new Point(55, 74);
            btnDesejado.Location = new Point(10, 30);
            btnDesejado.Size = new Size(27, 26);
            btnDesejado.Cursor = Cursors.Hand;
            btnDesejado.BackColor = objetoFigurinha.Status == "Desejada" ? System.Drawing.Color.LightCoral : System.Drawing.Color.White;
            btnDesejado.Tag = objetoFigurinha;

            Button btnObtido = new Button();
            btnObtido.Text = "✔";
            btnObtido.FlatStyle = FlatStyle.Flat;
            btnObtido.FlatAppearance.BorderSize = 1;
            btnObtido.FlatAppearance.BorderColor = Color.DimGray;
            btnObtido.BackColor = Color.LightGreen;
            btnObtido.Location = new Point(10, 95);
            btnObtido.Size = new Size(27, 26);
            btnObtido.Cursor = Cursors.Hand;
            btnObtido.BackColor = objetoFigurinha.Status == "Obtida" ? System.Drawing.Color.LightGreen : System.Drawing.Color.White;
            btnObtido.Tag = objetoFigurinha;
            btnObtido.Click += btnObtido_Click;


            Button btnVer = new Button();
            btnVer.Text = "👁";
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.FlatAppearance.BorderSize = 1;
            btnVer.BackColor = System.Drawing.Color.LightCyan;
            btnVer.Location = new Point(30, 100 );
            btnVer.Size = new Size(27, 26);
            btnVer.Cursor = Cursors.Hand;
            btnVer.Tag = objetoFigurinha;
            btnVer.Click += btnVer_Click;


            Button btnExcluir = new Button();
            btnExcluir.Text = "🗑";
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.FlatAppearance.BorderSize = 1;
            btnExcluir.BackColor = System.Drawing.Color.LightGray;
            btnExcluir.Location = new Point(20, 100);
            btnExcluir.Size = new Size(27, 26);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Tag = objetoFigurinha;
            btnExcluir.Click += btnExcluir_Click;

            //posição dos botões
            btnExcluir.Location = new System.Drawing.Point(20, 100);
            btnVer.Location = new System.Drawing.Point( 30, 100);
            btnDesejado.Location = new System.Drawing.Point(10, 30);
            btnObtido.Location = new System.Drawing.Point(10, 95);

            //controles
            pianel.Controls.Add(lbl);
            pianel.Controls.Add(btnDesejado);
            pianel.Controls.Add(btnObtido);
            pianel.Controls.Add(btnVer);
            pianel.Controls.Add(btnExcluir);
            pianel.Controls.Add(picFiguDesti);

            picFiguDesti.SendToBack();
            btnDesejado.BringToFront();
            btnObtido.BringToFront();
            btnExcluir.BringToFront();
            btnVer.BringToFront();
            
            if(flpFigu != null)
               flpFigu.Controls.Add(pianel);


        }

        void Filtrar()
        {
            LimparFlow();

            string pesquisa = txtPesquisa.Text.ToLower().Trim();

            foreach(var cards in frmListaFigurinhas.AlbumGeral)
            {
                bool cor = false;

                if(rbTodas.Checked)
                {
                    cor = true;   
                }
                else if (rbComum.Checked && cards.Raridade == "Comum")
                {
                    cor = true;
                }
                else if (rbRara.Checked && cards.Raridade == "Rara")
                {
                    cor = true;
                }
                else if (rbLendaria.Checked && cards.Raridade == "Lendaria")
                {
                    cor = true;
                }

                //  bool status = false;
                //if (rbStatusTodas.Checked)
                //status = true;
                //  if (rbObtida.Checked && cards.Status == "Obtida")
                //   status = true;
                //  else if (rbDesejada.Checked && cards.Status == "Desejada")
                //     status = true;

                //checa se o nome bate com o registrado, agora
                //se estiver vazio ele mostra todos os nomes
                //  bool texto = string.IsNullOrEmpty(pesquisa) ||
                //     cards.Nome.ToLower().Contains(pesquisa);

                //  bool texto = string.IsNullOrEmpty(pesquisa) || (cards.Nome ?? "").ToLower().Contains(pesquisa);

                // Status: se nenhum status marcado, mostramos todos
                bool status = true;
                if (rbObtida != null && rbObtida.Checked) status = cards.Status == "Obtida";
                else if (rbDesejada != null && rbDesejada.Checked) status = cards.Status == "Desejada";

                bool texto = string.IsNullOrEmpty(pesquisa) || (cards.Nome ?? "").ToLower().Contains(pesquisa);


                if (cor && texto && status)
                {
                    paginaCompleta(cards.Imagem, cards.Nome, cards.Raridade, cards);
                }
            }

        }

        //csharp frmListaFigurinhas.cs
// Descartar com segurança imagens e controles do FlowLayoutPanel
        void LimparFlow()
        {
            if (flpFigu == null) return;
            // Copia para array para evitar problemas de iteração enquanto disposa
            var controles = flpFigu.Controls.Cast<Control>().ToArray();

            foreach (var ctrl in controles)
            {
                try
                {
                    // Procura PictureBox dentro do painel e libera a imagem
                    var pb = ctrl.Controls.OfType<PictureBox>().FirstOrDefault();
                    if (pb != null)
                    {
                        if (pb.Image != null)
                        {
                            try { pb.Image.Dispose(); } catch { }
                            pb.Image = null;
                        }
                        // dispose do PictureBox
                        try { pb.Dispose(); } catch { }
                    }

                    // Dispose de demais filhos
                    var filhos = ctrl.Controls.Cast<Control>().ToArray();
                    foreach (var f in filhos)
                    {
                        try { f.Dispose(); } catch { }
                    }

                    // Dispose do próprio controle (p. ex. Panel)
                    try { ctrl.Dispose(); } catch { }
                }
                catch
                {
                    // Não propagar erro de limpeza, apenas tentar continuar
                }
            }

            // Finalmente limpar a coleção e forçar redraw
            flpFigu.Controls.Clear();
            flpFigu.Invalidate();
            System.Windows.Forms.Application.DoEvents();
        }


        // Diagnóstico: escreve no Output do VS sobre o conteúdo do AlbumGeral
        void DiagnosticoAlbum()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("--------- Diagnostico AlbumGeral ---------");
                System.Diagnostics.Debug.WriteLine($"AlbumGeral.Count = {AlbumGeral.Count}");
                for (int i = 0; i < AlbumGeral.Count; i++)
                {
                    var f = AlbumGeral[i];
                    bool imgNull = f.Imagem == null;
                    string size = imgNull ? "-" : $"{f.Imagem.Width}x{f.Imagem.Height}";
                    System.Diagnostics.Debug.WriteLine($"{i}: Nome='{f.Nome}', Raridade='{f.Raridade}', Status='{f.Status}', ImagemNull={imgNull}, Size={size}, Hash={(f.Imagem != null ? f.Imagem.GetHashCode().ToString() : "-")}");
                }
                System.Diagnostics.Debug.WriteLine("------------------------------------------");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("DiagnosticoAlbum erro: " + ex.Message);
            }
        }


        private void btnDesejado_Click(object sender, EventArgs e)
        {
            // Descobre qual botão foi clicado e recupera a figurinha da Tag
            Button botao = (Button)sender;
            Figurinha figu = (Figurinha)botao.Tag;

            // Altera o status na lista global
            figu.Status = "Desejada";

            MessageBox.Show($"{figu.Nome} foi marcada como Desejada!", "Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Filtrar();
        }

        //  
        private void btnObtido_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            Figurinha figu = (Figurinha)botao.Tag;

            figu.Status = "Obtida";

            MessageBox.Show($"{figu.Nome} foi adicionada às suas Obtidas!", "Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Filtrar();
        }

        
        private void btnVer_Click(object sender, EventArgs e)
        {
            // Button botao = (Button)sender;
            //Figurinha figu = (Figurinha)botao.Tag;

            // Procura se o Form1 já está aberto na lista de telas do Windows
            //frmCadastroFigurinhas formCadastro = (frmCadastroFigurinhas)Application.OpenForms["Form1"];

            // if (formCadastro != null)
            //{
            // 1. Passa a figurinha clicada para o Form1 preencher a tela dele
            //    formCadastro.CarregarDadosParaEdicao(figu);

            // 2. Traz o Form1 para a frente do usuário
            //       formCadastro.BringToFront();

            // 3. Fecha o Form2 (Lista de Figurinhas) para o usuário poder editar em paz
            //     this.Close();
            // }
            // else
            //{
            // Caso o Form1 tenha sido fechado por algum motivo, abrimos um novo
            //  frmCadastroFigurinhas novoCadastro = new frmCadastroFigurinhas();
            //novoCadastro.Show();
            //novoCadastro.CarregarDadosParaEdicao(figu);
            // this.Close();
            //}

            Button botao = (Button)sender;
            Figurinha figu = (Figurinha)botao.Tag;

            // Monta uma mensagem detalhada com os dados atuais da figurinha
            string detalhes = $" DETALHES DA FIGURINHA" +
                              Environment.NewLine +
                              $"Nome do Jogador: {figu.Nome}" +
                              Environment.NewLine +
                              $"Raridade: {figu.Raridade}" +
                              Environment.NewLine +
                              $"Status no Álbum: {figu.Status}";

            MessageBox.Show(detalhes, "Visualizar Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            Figurinha figu = (Figurinha)botao.Tag;

            
            DialogResult confirmacao = MessageBox.Show(
                $"Tem certeza de que deseja apagar permanentemente a figurinha do {figu.Nome}?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            
            if (confirmacao == DialogResult.Yes)
            {
                
                AlbumGeral.Remove(figu);

                MessageBox.Show("Figurinha excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                
                Filtrar();
            }
        }




        //telas
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void figurinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFigurinhas frm = new frmCadastroFigurinhas();
            frm.ShowDialog();
        }

        private void minhaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMimFigu frm = new frmMimFigu();
            frm.Show();
        }

        private void rbComum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComum.Checked) Filtrar();
        }

        private void rbRara_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRara.Checked) Filtrar();
        }

        private void rbLendaria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLendaria.Checked) Filtrar();
        }

        private void rbTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodas.Checked) Filtrar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Filtrar(); //atualiza ao mesmo tempo que o usuário digita
        }

        private void rbDesejada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesejada.Checked) Filtrar();
        }

        private void rbObtida_CheckedChanged(object sender, EventArgs e)
        {
            if (rbObtida.Checked) Filtrar();
        }
    }
}
