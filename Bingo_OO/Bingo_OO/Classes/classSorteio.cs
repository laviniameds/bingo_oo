using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo_OO.Classes
{
    public class classSorteio
    {
        private int[] arraySorteados;

        private int[] sortear()
        {
            arraySorteados = new int[75];
            for (int i = 1; i <= 75; i++) arraySorteados[i - 1] = i;
            Random ran = new Random();
            for (int i = 0; i < arraySorteados.Length; i++)
            {
                int pos = ran.Next(1, 75);
                int temp = arraySorteados[i];
                arraySorteados[i] = arraySorteados[pos];
                arraySorteados[pos] = temp;
            }
            return arraySorteados;
        }

        public int cont = 0;

        private string sorteado; 

        private string clicarSortear()
        {
            classCartela cart = new classCartela();
            string temp;
            if (cont > 75)
            {
                temp = ArraySorteados.GetValue(cont).ToString();
                //cart.ArmSorteio.SetValue(Convert.ToInt32(temp), cont);
                cont++;
                return temp;
            }
            else
            {
                return temp = "--";
            }
        }

        public int[] ArraySorteados
        {
            get { return arraySorteados; }
            set { arraySorteados = sortear(); }
        }

        public string Sorteado
        {
            get {return sorteado;}
            set {sorteado = clicarSortear();}
        }
    }
}
