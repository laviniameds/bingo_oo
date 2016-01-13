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
            int[] array = c.encherCartela();
            b1.Text = array[0].ToString();
            b2.Text = array[1].ToString();
            b3.Text = array[2].ToString();
            b4.Text = array[3].ToString();
            b5.Text = array[4].ToString();
            b6.Text = array[5].ToString();
            b7.Text = array[6].ToString();
            b8.Text = array[7].ToString();
            b9.Text = array[8].ToString();
            b10.Text = array[9].ToString();
            b11.Text = array[10].ToString();
            b12.Text = array[11].ToString();
            b13.Text = array[12].ToString();
            b14.Text = array[13].ToString();
            b15.Text = array[14].ToString();
            b16.Text = array[15].ToString();
            b17.Text = array[16].ToString();
            b18.Text = array[17].ToString();
            b19.Text = array[18].ToString();
            b20.Text = array[19].ToString();
            b21.Text = array[20].ToString();
            b22.Text = array[21].ToString();
            b23.Text = array[22].ToString();
            b24.Text = array[23].ToString();
        }
    }
}
