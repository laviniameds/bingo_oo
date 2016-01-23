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
            Cartela c = new Cartela();
            c.Text = "Cartela" + ++cont;
            c.Show();
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
    }
}
