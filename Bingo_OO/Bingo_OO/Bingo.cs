using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bingo_OO.Classes;

namespace Bingo_OO
{
    public partial class Bingo : Form
    {
        classBingo b = new classBingo();

        public Bingo()
        {
            InitializeComponent();
            novaCartela.Enabled = false;
            terminarJogo.Enabled = false;
        }

        private void novoJogoMenu_Click(object sender, EventArgs e)
        {
            novaCartela.Enabled = true;
            terminarJogo.Enabled = true;
            InicSorteio();
            novoJogoMenu.Enabled = false;
            b.cont = 0;
            b.chamarNovaCartela();
        }

        public void InicSorteio()
        {
            
        }

        private void novaCartela_Click(object sender, EventArgs e)
        {
            classBingo b = new classBingo();
            b.chamarNovaCartela();
        }

        private void terminarJogo_Click(object sender, EventArgs e)
        {

            terminarJogo.Enabled = false;
            novaCartela.Enabled = false;
            novoJogoMenu.Enabled = true;
        }
    }
}
