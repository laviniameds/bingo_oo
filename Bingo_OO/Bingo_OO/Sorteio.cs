using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace Bingo_OO
{
    public partial class Sorteio : Form
    {
        int[] sorteados = new int[75];
        int cont = 0;
        public Sorteio()
        {
            InitializeComponent();
            this.ControlBox = false;
            classSorteio s = new classSorteio();
            sorteados = s.sortear();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            if (cont < 75)
            {
                lblSorteado.Text = sorteados[cont].ToString();
                cont++;
            }
            else
            {
                lblSorteado.Text = "--";
                btnSortear.Enabled = false;
            }
        }
    }
}
