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
            classBingo b = new classBingo();
            b.numSorteados = ArraySorteados;
            return ArraySorteados;
        }
        private int contNumSaiu;
        public void clicarSortear()
        {
            classBingo b = new classBingo();
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form f in forms)
            {
                if (f.Name == "Sorteio")
                {
                    if (contNumSaiu < 75)
                    {
                        f.Controls["lblSorteado"].Text = ArraySorteados.GetValue(contNumSaiu).ToString();
                        ListBox[] lb = f.Controls.OfType<ListBox>().ToArray();
                        foreach (ListBox l in lb)
                            if (l.Name == "listBox1") l.Items.Add(f.Controls["lblSorteado"].Text);
                        contNumSaiu++;
                        b.qtdSaiu++;
                    }
                    else
                    {
                        f.Controls["lblSorteado"].Text = "--";
                        f.Controls["btnSortear"].Enabled = false;
                    }
                }
            }
        }
        public classSorteio()
        {
            contNumSaiu = 0;
            sortear();
        }
        public int[] ArraySorteados
        {
            get { return arraySorteados; }
            set { arraySorteados = value; }
        }
    }
}
