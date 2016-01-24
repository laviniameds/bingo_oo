using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo_OO.Classes
{
    public class classCartela
    {
        private int id;
        private Panel painel;
        private Panel encherPainel()
        {
            int[] r = new int[24];
            int[] arrayTemp = new int[75];
            for (int i = 1; i <= 75; i++) arrayTemp[i - 1] = i;
            Random ran = new Random();
            for (int i = 0; i < arrayTemp.Length; i++)
            {
                int pos = ran.Next(1, 75);
                int temp = arrayTemp[i];
                arrayTemp[i] = arrayTemp[pos];
                arrayTemp[pos] = temp;
            }
            for (int i = 0; i < r.Length; i++) r[i] = arrayTemp[i];

            painel = new Panel();
            painel.Width = 314;
            painel.Height = 289;
            painel.BackColor = Color.White;
            painel.Location = new Point(14, 70);
            Button[,] botoes = new Button[5, 5];
            int cont = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (!(i == 2 && j == 2))
                    {
                        botoes[i, j] = new Button();
                        botoes[i, j].Text = r[cont].ToString();
                        botoes[i, j].Size = new Size(62, 56);
                        botoes[i, j].Location = new Point(62 * i, 55 * j);
                        botoes[i, j].Click += new EventHandler(this.botoes_Click);
                        painel.Controls.Add(botoes[i, j]);
                        cont++;
                    }
                }
            return painel;
        }
        private int contGanhou = 0;
        private void botoes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            classBingo b = new classBingo();
            for (int i = -1; i < b.qtdSaiu; i++)
                if (btn.Text == b.numSorteados.GetValue(i+1).ToString())
                {
                    btn.Enabled = false;
                    contGanhou++;
                }
            if (contGanhou == 24)
            {
                MessageBox.Show("Parabéns Cartela " + this.Id + "! Você ganhou o jogo :D");
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form f in forms)
                {
                    if (f.Name == "Bingo")
                    {
                        f.MainMenuStrip.Items[0].Enabled = true;
                        f.MainMenuStrip.Items[1].Enabled = false;
                        f.MainMenuStrip.Items[2].Enabled = false;                       
                    }
                    else f.Close();
                }
            }
        }
        public Panel Painel
        {            
            set {painel = encherPainel();}
            get { return painel; }
        }
        public int Id
        {
            get {return id;}
            set {id = value;}
        }
        public classCartela() {encherPainel();}
    }
}
