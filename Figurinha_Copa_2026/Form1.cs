using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figurinha_Copa_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void listaDeFigurinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFigurinhas frm = new frmListaFigurinhas();
            frm.Show();
        }

        private void cadastroDeFigurinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFigurinhas frm = new frmCadastroFigurinhas();
            frm.Show();
        }

        private void minhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMimFigu frm = new frmMimFigu();
            frm.Show();
        }

        private void listaDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFigurinhas frm = new frmListaFigurinhas();
            frm.Show();
        }
    }
}
