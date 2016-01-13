using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class classSorteio
    {
        public int[] sortear()
        {
            int[] sorteados = new int[75];
            for (int i = 1; i <= 75; i++) sorteados[i - 1] = i;
            Random ran = new Random();
            for (int i = 0; i < sorteados.Length; i++)
            {
                int pos = ran.Next(1, 75);
                int temp = sorteados[i];
                sorteados[i] = sorteados[pos];
                sorteados[pos] = temp;
            }
            return sorteados;
        }
    }
}
