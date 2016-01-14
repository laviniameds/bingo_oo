using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class classCartela
    {
        public int[] encherCartela()
        {
            int[] r = new int[24];
            int[] arrayTemp = new int[75];
            for (int i = 1; i <= 75; i++) arrayTemp[i - 1] = i;
            Random ran = new Random();
            for (int i = 0; i < arrayTemp.Length; i++)
            {
                int pos = ran.Next(1, 75);
                int temp = arrayTemp[i];
                arrayTemp[i] = arrayTemp[pos];
                arrayTemp[pos] = temp;
            }
            for (int i = 0; i < r.Length; i++) r[i] = arrayTemp[i];
            return r;
        }

        static int[] _armSorteio = new int[75];

        public int[] armSorteio
        {
            set { _armSorteio = value; }
            get { return _armSorteio; }
        }      

    }
}
