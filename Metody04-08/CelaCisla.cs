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

        public static int Faktorial(int a)
        {
            int faktorial = 1;
            if (a < 0) throw new ArgumentException("Faktoriál nelze počítat ze záporného čísla");
            else if (a > 12) throw new ArgumentOutOfRangeException("Příliš velké číslo pro faktoriál");
            for (int i = 1; i <= a; ++i)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        public static int CifLichSoucet(int a)
        {
            int cifra = 0;
            int ciflichsoucet = 0;
            while (a > 0)
            {
                cifra = a % 10;
                if (cifra % 2 != 0)
                {
                    ciflichsoucet += cifra;
                }
                a = a / 10;
            }
            return ciflichsoucet;
        }

        public static bool JePrvocislo(int a)
        {
            bool prvocislo = a != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(a) && prvocislo; ++delitel)
            {
                if (a % delitel == 0) prvocislo = false;
            }
            return prvocislo;
        }

        public int PocetDeliteluSud(int a)
        {
            int pocet = 0;
            for (int i = 1; i <= a; ++i)
            {
                if (a % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        ++pocet;
                    }
                }
            }
            return pocet;
        }
    }
}
