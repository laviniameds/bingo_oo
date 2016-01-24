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
        public Bingo()
        {
            InitializeComponent();
        }

        classBingo b = new classBingo();

        protected void novoJogoMenu_Click(object sender, EventArgs e)
        {
            b.NovoJogo();
        }

        private void novaCartela_Click(object sender, EventArgs e)
        {
            b.chamarNovaCartela();
        }

        private void terminarJogo_Click(object sender, EventArgs e)
        {
            b.TerminarJogo();
        }
    }
}
