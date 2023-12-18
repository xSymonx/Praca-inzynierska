using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkcja_Pociagow
{
    public class Planowanie_Produkcji : Czynnosc
    {
        public Planowanie_Produkcji()
        {
        }

        public static int[] CzasProdukcji(int poczatkowy, int koncowy)
        {
            int liczba_wierzcholkow = koncowy - poczatkowy + 1;
            int wierzcholek_poczatkowy = poczatkowy;
            int[] d = new int[liczba_wierzcholkow + 1];
            int[] p = new int[liczba_wierzcholkow + 1];
            int[] czas = new int[liczba_wierzcholkow + 1];
            int wierzcholek_x;
            int i = poczatkowy;
            int max = 0;
            Krawedz pom;
            Krawedz tymczas;

            List<Krawedz> krawedz = UstalanieKolejnosciCzynnosci();

            for (int j = 0; j < liczba_wierzcholkow + 1; j++)
            {
                d[j] = max;
                p[j] = -1;
            }
            d[wierzcholek_poczatkowy] = 0;
            i++;

            for (; i <= liczba_wierzcholkow; i++)
            {
                for (wierzcholek_x = 0; wierzcholek_x < (krawedz.Count()); wierzcholek_x++)
                {
                    pom = krawedz[wierzcholek_x];
                    for (int k = 0; k < krawedz.Count(); k++)
                    {
                        tymczas = krawedz[k];
                        if (pom.poczatek == tymczas.poczatek && tymczas.koniec <= koncowy)
                        {
                            if (d[tymczas.koniec] <= d[tymczas.poczatek] + tymczas.waga)
                            {
                                d[tymczas.koniec] = d[tymczas.poczatek] + tymczas.waga;
                                p[tymczas.koniec] = tymczas.poczatek;
                            }
                        }
                    }
                }
                czas = d;
            }
            return czas;
        }
    }
}

