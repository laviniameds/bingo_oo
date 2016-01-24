using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bingo_OO.Classes;

namespace Bingo_OO
{
    public partial class Sorteio : Form
    {
        public Sorteio()
        {
            InitializeComponent(); 
        }

        classSorteio s = new classSorteio();

        private void btnSortear_Click(object sender, EventArgs e)
        {
            s.clicarSortear(); 
        }
    }
}
