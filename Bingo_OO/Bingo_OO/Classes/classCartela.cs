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

            Panel p = new Panel();
            p.Width = 314;
            p.Height = 289;
            p.Location = new Point(14, 70);
            p.BackColor = Color.White;
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
                        botoes[i, j].Location = new Point(61 * i, 52 * j);
                        botoes[i, j].Click += new EventHandler(this.botoes_Click);
                        p.Controls.Add(botoes[i, j]);
                        cont++;
                    }
                }
            return p;
        }

        private int contGanhou = 0;

        private bool ganhou = false;

        private static int[] armSorteio = new int[75];

        private void botoes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < ArmSorteio.Length; i++)
                if (btn.Text == ArmSorteio.GetValue(i).ToString())
                {
                    btn.Enabled = false;
                    contGanhou++;
                }
            if (contGanhou == 24)
            {
                Ganhou = true;
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form f in forms)
                {
                    if (f.Name == "Bingo")
                    {
                        f.MainMenuStrip.Items[0].Enabled = true;
                        f.MainMenuStrip.Items[1].Enabled = false;
                        f.MainMenuStrip.Items[2].Enabled = false;
                        for (int i = 0; i < 75; i++) ArmSorteio.SetValue(0, i);
                    }
                    else f.Close();
                }
            }
        }

        public bool Ganhou
        {
            get { return ganhou; }
            set { ganhou = value; }
        }

        public int[] ArmSorteio
        {
            get {return armSorteio;}
            set {armSorteio = value;}
        }

        public classCartela(Cartela c)
        {
            c.Controls.Add(encherPainel());
        }
    }
}
