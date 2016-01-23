using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bingo_OO.Classes
{
    public class classSorteio
    {
        private int[] arraySorteados = new int[75];

        private int[] sortear()
        {
            for (int i = 1; i <= 75; i++) ArraySorteados[i - 1] = i;
            Random ran = new Random();
            for (int i = 0; i < ArraySorteados.Length; i++)
            {
                int pos = ran.Next(1, 75);
                int temp = ArraySorteados[i];
                ArraySorteados[i] = ArraySorteados[pos];
                ArraySorteados[pos] = temp;
            }
            return ArraySorteados;
        }

        private string sorteado; 

        public string clicarSortear()
        {
            cont++;
            if (cont < 75)
            {
                sorteado = ArraySorteados.GetValue(cont).ToString();
                //cart.ArmSorteio.SetValue(Convert.ToInt32(temp), cont);
                return sorteado;
            }
            else
            {
                return sorteado = "--";
            }
        }

        public int[] ArraySorteados
        {
            get { return arraySorteados; }
            set { arraySorteados = value; }
        }

        public int cont = -1;

        public string Sorteado
        {
            get {return sorteado;}
            set { sorteado = clicarSortear(); }
        }

        public classSorteio()
        {
            sortear();
            clicarSortear();
        }
    }
}
