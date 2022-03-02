using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08
{
    class CelaCisla
    {
        public static double Mocnina(int a, int b)
        {
            double vysledek = 0, mocnina = 1;
            if (b > 0)
            {
                for (int i = 1; i <= b; ++i)
                {
                    mocnina *= a;
                }
                vysledek = mocnina;
            }
            else
            {
                for (int i = 1; i <= -b; ++i)
                {
                    mocnina *= a;
                }
                vysledek = 1 / mocnina;
            }
            return vysledek;
        }
    }
}
