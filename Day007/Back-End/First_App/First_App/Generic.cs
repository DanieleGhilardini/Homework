using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    internal class Generic<TValue1, TValue2>
    {
        private string[] nomi1 = new string[5];
        private string[] nomi2 = new string[5];
        private TValue1[] valori1 = new TValue1[5];
        private TValue2[] valori2 = new TValue2[5];
        public void Add(string nome1, string nome2, TValue1 valore1, TValue2 valore2)
        {
            for (int i = 0; i < nomi1.Length; i++)
            {
                if (nomi1[i] == null)
                {
                    nomi1[i] = nome1;
                    nomi2[i] = nome2;
                    valori1[i] = valore1;
                    valori2[i] = valore2;
                    return;
                }
            }
        }
    }
}
