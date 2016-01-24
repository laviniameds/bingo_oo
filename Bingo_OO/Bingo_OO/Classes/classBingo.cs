using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_OO.Classes
{
    public class classBingo
    {
        private static int[] _numSorteados = new int[75];
        private static int _qtdSaiu = 0;
        private int contNumCartela = 0;
        public void chamarNovaCartela()
        {
            Cartela cart = new Cartela();
            classCartela c = new classCartela();
            cart.Text = "Cartela " + ++contNumCartela;
            c.Id = contNumCartela;
            cart.Controls.Add(c.Painel);
            cart.Show();
        } 
        public void NovoJogo()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form f in forms)
            {
                f.MainMenuStrip.Items[0].Enabled = false;
                f.MainMenuStrip.Items[1].Enabled = true;
                f.MainMenuStrip.Items[2].Enabled = true;
            }
            for (int i = 0; i < 75; i++) numSorteados[i] = 0;
            _qtdSaiu = 0;
            this.contNumCartela = 0;
            chamarPainelSorteio();
            chamarNovaCartela();
        }
        public void TerminarJogo()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja finalizar o jogo em andamento?", "Jogo Finalizado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form f in forms)
                {
                    if (!(f.Name == "Bingo")) f.Close();
                    else
                    {
                        f.MainMenuStrip.Items[0].Enabled = true;
                        f.MainMenuStrip.Items[1].Enabled = false;
                        f.MainMenuStrip.Items[2].Enabled = false;
                    }
                }
            }
        }
        public void chamarPainelSorteio()
        {
            Sorteio s = new Sorteio();
            s.Show();
        }
        public int[] numSorteados
        {
            get { return _numSorteados; }
            set { _numSorteados = value; }
        }
        public int qtdSaiu
        {
            get { return _qtdSaiu; }
            set { _qtdSaiu = value; }
        }
    }
}
