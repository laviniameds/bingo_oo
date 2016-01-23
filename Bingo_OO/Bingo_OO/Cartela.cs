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
    public partial class Cartela : Form 
    {
        public Cartela()
        {
            InitializeComponent();
            classCartela c = new classCartela();
            this.Controls.Add(c.Painel);
            if(c.Ganhou)MessageBox.Show("Parabéns " + ActiveForm.Text + "! Você ganhou o jogo :D");
        }
    }
}
