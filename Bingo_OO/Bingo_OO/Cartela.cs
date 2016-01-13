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
        public Cartela()
        {
            InitializeComponent();
            classCartela c = new classCartela();
            Button[,] botoes = new Button[5,5];
            int[] array = c.encherCartela();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (!(i == 2 && j == 2))
                    {
                        botoes[i, j] = new Button();
                        botoes[i, j].Text = array[i].ToString();
                        botoes[i, j].Size = new Size(62, 56);
                        botoes[i, j].Location = new Point(61 * i, 52 * j);
                        panel1.Controls.Add(botoes[i,j]);
                    }
                }
        }
    }
}
