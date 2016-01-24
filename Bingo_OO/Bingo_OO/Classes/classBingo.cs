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
        public int cont = 0;
        public void chamarNovaCartela()
        {
            Cartela cart = new Cartela();
            classCartela c = new classCartela();
            cart.Text = "Cartela " + ++cont;
            c.Id = cont;
            cart.Controls.Add(c.Painel);
            cart.Show();
        } 
        public void NovoJogo()
        {
            Sorteio s = new Sorteio();
            s.Show();
        }
        public void TerminarJogo()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja finalizar o jogo em andamento?", "Jogo Finalizado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form f in forms) if (!(f.Name == "Bingo")) f.Close();
            }
        }
        public void chamarPainelSorteio()
        {
            Sorteio s = new Sorteio();
            s.Show();
        }
        private static int[] _numSorteados = new int[75];
        public int[] numSorteados
        {
            get { return _numSorteados; }
            set { _numSorteados = value; }
        }
        private static int _qtdSaiu =0;
        public int qtdSaiu
        {
            get { return _qtdSaiu; }
            set { _qtdSaiu = value; }
        }
    }
}
