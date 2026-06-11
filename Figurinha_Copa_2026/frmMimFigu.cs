using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Figurinha_Copa_2026.frmCadastroFigurinhas;

namespace Figurinha_Copa_2026
{
    public partial class frmMimFigu : Form
    {
        public frmMimFigu()
        {
            InitializeComponent();
            this.Shown += frmMimFigu_Shown;
        }

        private void frmMimFigu_Shown(object sender, EventArgs e)
        {
            flpMinhaFigu.Controls.Clear();

            foreach (var cards in frmListaFigurinhas.AlbumGeral)
            {
                paginaCompleta(cards.Imagem, cards.Nome, cards.Raridade);
            }
        }


        void CorRaridade(string raridade)
        {
            switch (raridade)
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


        void paginaCompleta(Image image, string nome, string raridade)
        {
            CorRaridade(raridade);

            Panel pianel = new Panel();
            pianel.Size = new Size(120, 120);
            pianel.BorderStyle = BorderStyle.FixedSingle;

            Label lbl = new Label();
            lbl.Text = nome;
            lbl.BackColor = Color.Transparent;
            lbl.Location = new Point(5, 5);
            lbl.TextAlign = ContentAlignment.MiddleCenter;


            PictureBox picFiguDesti = new PictureBox();
            picFiguDesti.Size = new Size(100, 100);
            picFiguDesti.Location = new Point(10, 20);
            picFiguDesti.SizeMode = PictureBoxSizeMode.StretchImage;
            picFiguDesti.Image = image;

            Button btnObtido = new Button();
            btnObtido.Text = "♥";
            btnObtido.FlatStyle = FlatStyle.Flat;
            btnObtido.FlatAppearance.BorderSize = 1;
            btnObtido.FlatAppearance.BorderColor = Color.DimGray;
            btnObtido.BackColor = Color.LightGreen;
            //btnDesejado.Location = new Point(55, 74);
            btnObtido.Location = new Point(Top, Left);
            btnObtido.Size = new Size(27, 26);
            btnObtido.Cursor = Cursors.Hand;

            btnObtido.Location = new System.Drawing.Point(Top, Left);
            pianel.Controls.Add(lbl);
            pianel.Controls.Add(btnObtido);
            pianel.Controls.Add(picFiguDesti);

            btnObtido.BringToFront();
            flpMinhaFigu.Controls.Add(pianel);




        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void figurinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFigurinhas frm = new frmCadastroFigurinhas();
            frm.Show();
        }

       

        private void listaDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFigurinhas frm = new frmListaFigurinhas();
            frm.Show();
        }
    }
}
