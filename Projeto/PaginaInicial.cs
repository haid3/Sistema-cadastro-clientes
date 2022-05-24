using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            NovoCliente inicio = new NovoCliente();
            inicio.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaConta inicio = new NovaConta();
            inicio.ShowDialog();
        }
    }
}
