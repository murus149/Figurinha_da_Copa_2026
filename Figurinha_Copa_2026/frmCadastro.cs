using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Figurinha_Copa_2026
{
    public partial class frmCadastroFigurinhas : Form
    {
        public frmCadastroFigurinhas()
        {
            InitializeComponent();
        }

        public class Figurinha
        {
            public string Nome { get; set; }
            public System.Drawing.Image Imagem { get; set; }
            public string Raridade { get; set; }
            public string Status { get; set; }
        }
        void MsgAtencao(string msg)
        {
            MessageBox.Show(msg,"Atenção:",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        void MsgInfo(string message)
        {
            MessageBox.Show(message, "Informação!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //Manipulação e criação de arquivo .txt com os dados escritos
        bool ArquivoExiste(string local)
        {
            return File.Exists(local);
        }    

        //gravar o conteudo, se existir substitui
        void GravarArquivo(string caminho, string conteudo)
        {
            string pasta = Path.GetDirectoryName(caminho);
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            //gravar o conteúdo
            File.WriteAllText(caminho, conteudo);
        }
        //

        string CaminhoArquivo(string tipoCadastro, string Nome)
        {
            //Diretorio Raiz
            //AppDomain = O Executavel em si
            //CurrentDomain = O processo em execução (gerenciador de tarefas)
            //BaseDirectory = local da onde o .exe está sendo executado

            string raiz = AppDomain.CurrentDomain.BaseDirectory;

            //montar o diretório
            return Path.Combine(raiz, tipoCadastro,Nome + ".txt");
        }

               
        void salvar()
        {
            //monta e recupera o diretorio 
            string diretorio = CaminhoArquivo("Cliente", txtNomeFigurinha.Text);


            //importante validar a exist~encia do mesmo
            try
            {
                //validação
                if(ArquivoExiste(diretorio))
                {
                    MsgAtencao("Já existe um registro com esse Nome!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MsgAtencao("Falha ao salvar os dados." +
                    Environment.NewLine +
                    "Erro original:" + ex.Message);
            }

            try
            {
                //gravação do registro
                GravarArquivo(diretorio, GetInformacao());

                MsgInfo("Registro slavo com sucesso!"+
                    Environment.NewLine +
                    "Salvo em:"+ diretorio);
            }
            catch(Exception ex)
            {
                MsgInfo("falha ao salvar o registro!" +
                    Environment.NewLine +
                    "Erro original:" + ex.Message);
                return;
            }

        }

        string GetInformacao()
        {
            string dados =
                "Nome da figurinha:" + txtNomeFigurinha +
                Environment.NewLine +
                "Selecão:" + txtSelecao +
                Environment.NewLine +
                "Salvo em:" + txtDiretorio;
            return dados;
        }
        //



        //método para recuperar e enviar os status dos radios buttons
        //para o formulário de Listagem das Figurinhas
        /*
        void StatusRB()
        {
            string raridade = "";
            string status = "";
            
            if(string.IsNullOrEmpty(raridade))
            {
                MessageBox.Show("cadastrado com sucesso!");
            }
            if (rbComum.Checked)  raridade = "Comum";
                else if (rbRara.Checked) raridade = "Rara";
                else if (rbLendaria.Checked) raridade = "Lendária";
                    switch (raridade)
                    {
                        case "Comum":
                            
                        case "Rara":

                        case "Lendaria":
                            frmListaFigurinhas frm = new frmListaFigurinhas(picFigurinha.Image, raridade);
                            frm.Show();
                            break;

                    }

            if (rbDesejada.Checked) status = "Desejada";
               else if (rbObitida.Checked) status = "Obtida";
                    switch(status)
                    {
                      case "Desejada":
                      case "Obtida":
                          frmListaFigurinhas form2 = new frmListaFigurinhas(status);
                          form2.Show();
                          break;
                    }

        

        }*/

        void StatusRB()
        {
            if(txtNomeFigurinha.Text == "")
            { MessageBox.Show("Preencha o campo do Nome!");
                return;
            }
            if(txtSelecao.Text == "")
            {
                MessageBox.Show("Preencha o campo da Seleção!");
                return;
            }

            if (picFigurinha.Image == null)
            {
                MessageBox.Show("Selecione uma imagem.");
                return;
            }

            //raridade
            string raridade = "";

            if (rbComum.Checked) raridade = "Comum";
            else if (rbRara.Checked) raridade = "Rara";
            else if (rbLendaria.Checked) raridade = "Lendaria";

            if (string.IsNullOrEmpty(raridade))
            {
                MessageBox.Show("Selecione a raridade.");
                return;
            }

            // Status
            string status = "";

            if (rbDesejada.Checked) status = "Desejada";
            else if (rbObtida.Checked) status = "Obtida";

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Selecione o status.");
                return;
            }
            // Criamos a figurinha com os dados da tela
            Figurinha novaFigurinha = new Figurinha();
            novaFigurinha.Nome = txtNomeFigurinha.Text; 
            novaFigurinha.Imagem = picFigurinha.Image;
            novaFigurinha.Raridade = raridade;
            novaFigurinha.Status = status;


            // Adiciona ao "Banco de Dados temporário" estático do Form2
            frmListaFigurinhas.AlbumGeral.Add(novaFigurinha);


            //Sempre adiciona na lista geral (Form2)
            frmListaFigurinhas form2 =
                new frmListaFigurinhas();

            form2.Show();

            //SE for obtida  passa para Form3
            if (status == "Obtida")
            {
                frmMimFigu form3 = new frmMimFigu();
                form3.Show();
            }

            MessageBox.Show("Figurinha cadastrada com sucesso!");
        }
        //
        //public void CarregarDadosParaEdicao(Figurinha figu)
        //{

          //  txtNomeFigurinha.Text = figu.Nome;
            //picFigurinha.Image = figu.Imagem;
           
          //  if (figu.Raridade == "Comum") rbComum.Checked = true;
            //else if (figu.Raridade == "Rara") rbRara.Checked = true;
            //else if (figu.Raridade == "Lendária") rbLendaria.Checked = true;

            //if (figu.Status == "Obtida") rbObtida.Checked = true;
            //else rbDesejada.Checked = true;

            // Opcional: Você pode guardar essa figurinha em uma variável global no Form1 
            // se quiser atualizar a MESMA figurinha em vez de criar uma cópia ao salvar.
        //}



        //Manipulação e envio de arquivo de imagem para o FORM ListaFigurinhas

        void ManipularImagem()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pastaDestino = Path.Combine(System.Windows.Forms.Application.StartupPath,"figurinha");
                Directory.CreateDirectory(pastaDestino);

                //seleciona o arquivo
                string origem = openFileDialog1.FileName;

                //captura pelo nome
                string nomeArquivo = Path.GetFileName(origem);

                //caminho final
                string destinoFinal = Path.Combine(pastaDestino, nomeArquivo);

                //copia o arquivo
                File.Copy(origem, destinoFinal, true);

                //carrega a imagem sem trava-la
                using (var fs = new FileStream(destinoFinal, FileMode.Open, FileAccess.Read))
                {
                    using (var imgTemp = System.Drawing.Image.FromStream(fs))
                    {
                        // Clona a imagem para que ela não dependa do FileStream aberto
                        picFigurinha.Image = new Bitmap(imgTemp);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada.");
            }
        }
         
        //


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
            // Verifique se o jogador já existe na lista global antes de dar o .Add()
            var jogadorExistente = frmListaFigurinhas.AlbumGeral.FirstOrDefault(f => f.Nome == txtNomeFigurinha.Text);

            string raridade = rbComum.Checked ? "Comum" : (rbRara.Checked ? "Rara" : "Lendaria");
            string status = rbObtida.Checked ? "Obtida" : "Desejada";

            if (jogadorExistente != null)
            {
                jogadorExistente.Raridade = raridade;
                jogadorExistente.Status = status;
                jogadorExistente.Imagem = picFigurinha.Image;
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            else
            {
                // Cria e adiciona a nova figurinha à lista global
                var nova = new Figurinha
                {
                    Nome = txtNomeFigurinha.Text,
                    Imagem = picFigurinha.Image,
                    Raridade = raridade,
                    Status = status
                };

                frmListaFigurinhas.AlbumGeral.Add(nova);

                MessageBox.Show("Figurinha adicionada à lista com sucesso!");

                txtNomeFigurinha.Clear();
                txtSelecao.Clear();
                txtDiretorio.Clear();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ManipularImagem();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validações básicas
            if (string.IsNullOrWhiteSpace(txtNomeFigurinha.Text))
            {
                MsgAtencao("Preencha o campo do Nome!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSelecao.Text))
            {
                MsgAtencao("Preencha o campo da Seleção!");
                return;
            }

            if (picFigurinha.Image == null)
            {
                MsgAtencao("Selecione uma imagem.");
                return;
            }

            string raridade = rbComum.Checked ? "Comum" :
                              rbRara.Checked ? "Rara" :
                              rbLendaria.Checked ? "Lendaria" : "";

            if (string.IsNullOrEmpty(raridade))
            {
                MsgAtencao("Selecione a raridade.");
                return;
            }

            string status = rbDesejada.Checked ? "Desejada" :
                            rbObtida.Checked ? "Obtida" : "";

            if (string.IsNullOrEmpty(status))
            {
                MsgAtencao("Selecione o status.");
                return;
            }

            // Verifica existência e atualiza ou cria nova figurinha (clonando a imagem)
            var jogadorExistente = frmListaFigurinhas.AlbumGeral
                .FirstOrDefault(f => f.Nome.Equals(txtNomeFigurinha.Text, StringComparison.OrdinalIgnoreCase));

            if (jogadorExistente != null)
            {
                jogadorExistente.Raridade = raridade;
                jogadorExistente.Status = status;
                jogadorExistente.Imagem = new Bitmap(picFigurinha.Image); // clona
                MsgInfo("Cadastro atualizado com sucesso!");
            }
            else
            {
                var nova = new Figurinha
                {
                    Nome = txtNomeFigurinha.Text,
                    Imagem = new Bitmap(picFigurinha.Image), // clona para evitar dependência do stream
                    Raridade = raridade,
                    Status = status
                };

                frmListaFigurinhas.AlbumGeral.Add(nova);
                MsgInfo("Figurinha cadastrada com sucesso!");
            }

            // Abre a lista e, se for obtida, abre a tela pessoal
            var form2 = new frmListaFigurinhas();
            form2.Show();

            if (status == "Obtida")
            {
                var form3 = new frmMimFigu();
                form3.Show();
            }

            // Limpa a tela para novo cadastro
            txtNomeFigurinha.Clear();
            txtSelecao.Clear();
            txtDiretorio.Clear();
            picFigurinha.Image = null;
        }
    }
}
