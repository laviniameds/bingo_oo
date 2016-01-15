using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Bingo_OO
{
    public partial class Bingo : Form
    {
        int cont = 0;
        Cartela[] c = new Cartela[Int16.MaxValue];
        classCartela cCart = new classCartela();
        Sorteio s;
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
            s = new Sorteio();
            s.Show();
            novoJogoMenu.Enabled = false;
        }

        private void novaCartela_Click(object sender, EventArgs e)
        {
            c[cont] = new Cartela();
            c[cont].Show();
            c[cont].Text = "Cartela " + ++cont;
        }

        private void terminarJogo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja finalizar o jogo em andamento?", "Jogo Finalizado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result.Equals(DialogResult.OK))
            {
                for (int i = 0; i < cont; i++) c[i].Close();
                s.Close();
                terminarJogo.Enabled = false;
                novaCartela.Enabled = false;
                novoJogoMenu.Enabled = true;
                cont = 0;
                for (int i = 0; i < 75; i++) cCart.armSorteio.SetValue(0, i);
            }
        }
    }
}
