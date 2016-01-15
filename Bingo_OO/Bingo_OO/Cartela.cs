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
    public partial class Cartela : Form 
    {
        int contGanhou = 0;
        public Cartela()
        {
            InitializeComponent();
            classCartela c = new classCartela();
            Button[,] botoes = new Button[5,5];
            int[] array = c.encherCartela();
            int cont = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (!(i == 2 && j == 2))
                    {
                        botoes[i, j] = new Button();
                        botoes[i, j].Text = array[cont].ToString();
                        botoes[i, j].Size = new Size(62, 56);
                        botoes[i, j].Location = new Point(61 * i, 52 * j);
                        botoes[i, j].Click += new EventHandler(this.botoes_Click);
                        panel1.Controls.Add(botoes[i, j]);
                        cont++;
                    }
                }               
        }

        protected void botoes_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            classCartela c = new classCartela();
            for (int i = 0; i < c.armSorteio.Length; i++)
                if (btn.Text == c.armSorteio.GetValue(i).ToString())
                {
                    btn.Enabled = false;
                    contGanhou++;
                }
            if (contGanhou == 24)
            {
                MessageBox.Show("Parabéns " + ActiveForm.Text + "! Você ganhou o jogo :D");
                Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
                foreach (Form f in forms)
                {
                    if(f.Name == "Bingo")
                    {
                        f.MainMenuStrip.Items[0].Enabled = true;
                        f.MainMenuStrip.Items[1].Enabled = false;
                        f.MainMenuStrip.Items[2].Enabled = false;
                        for (int i = 0; i < 75; i++) c.armSorteio.SetValue(0, i);
                    }
                    else f.Close();
                }
            }
        }
    }
}
