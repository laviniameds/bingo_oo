﻿using System;
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
        classSorteio s = new classSorteio();
        classBingo b = new classBingo();
        public Sorteio()
        {
            InitializeComponent();
            this.ControlBox = false;       
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            lblSorteado.Text = s.Sorteado;
            listBox1.Items.Add(lblSorteado.Text);
            if (lblSorteado.Text == "--") btnSortear.Enabled = false;
            s.cont++;
            b.qtdSaiu = s.cont;
        }
    }
}
