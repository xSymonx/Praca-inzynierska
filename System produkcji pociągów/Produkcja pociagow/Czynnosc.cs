using System;
using System.Collections.Generic;

namespace Produkcja_Pociagow
{
    public class Czynnosc
    {
        protected int Liczba_porzadkowa { get; set; }
        protected string Nazwa { get; set; }
        public int Czas { get; set; }
        public List<int> Poprzednicy = new List<int>();

        public Czynnosc()
        { 
        }

        public static void PobierzCzynnosczPliku(List<Czynnosc> Czynnosci)
        {
            string zmienna_pom;
            int index_wystapienia;
            string zmienna_tymczas;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\szymo\OneDrive\Desktop\Praca Inzynierska spis czynnosci.csv");
            Czynnosc czynnosc = new Czynnosc();
            Czynnosci.Add(new Czynnosc() { Czas = 0, Nazwa = null, Liczba_porzadkowa = 0, Poprzednicy = null });

            for (int i = 1; i < 84; i++)
            {
                
                zmienna_pom = lines[i] + " ";
                index_wystapienia = zmienna_pom.IndexOf(';');
                zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                czynnosc.Liczba_porzadkowa = int.Parse(zmienna_tymczas);
                zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);

                index_wystapienia = zmienna_pom.IndexOf(';');
                zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                czynnosc.Nazwa = zmienna_tymczas;
                zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);

                index_wystapienia = zmienna_pom.IndexOf(';');
                zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                czynnosc.Czas = int.Parse(zmienna_tymczas);
                zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);

                while (zmienna_pom.IndexOf(' ') != -1)
                {
                    index_wystapienia = zmienna_pom.IndexOf(' ');
                    zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                    czynnosc.Poprzednicy.Add(int.Parse(zmienna_tymczas));
                    zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);
                }
                Czynnosci.Add(czynnosc);
                czynnosc = new Czynnosc();
            }
        }
        public static string PokazCzynnosc(Czynnosc czyn)
        {
            string czynnosc = "";

            if (czyn.Liczba_porzadkowa != 0)
            {
                if (czyn.Czas == 1)
                {
                    czynnosc += czyn.Liczba_porzadkowa + ". " + czyn.Nazwa + ", czas trwania " + czyn.Czas + " dzień.";
                }
                else
                {
                    czynnosc += czyn.Liczba_porzadkowa + ". " + czyn.Nazwa + ", czas trwania " + czyn.Czas + " dni.";
                }
                /*
                foreach (var item in czyn.Poprzednicy)
                {
                    czynnosc += item + " ";
                }*/
                czynnosc += "\n";
            }
            return czynnosc;
        }
        public static string PobierzNazweCzynnosci(Czynnosc czynnosc)
        {
            return czynnosc.Nazwa;
        }
        public static List<Krawedz> UstalanieKolejnosciCzynnosci()
        {
            List<Czynnosc> czynnosci = new List<Czynnosc>();
            Czynnosc.PobierzCzynnosczPliku(czynnosci);
            List<Krawedz> krawedz = new List<Krawedz>();
            Krawedz pom = new Krawedz();
            List<int> wagi = new List<int>();
            //wagi.Add(0);
            foreach (var item in czynnosci)
            {
                wagi.Add(item.Czas);
            }

            foreach (var item in czynnosci)
            {
                if (item.Poprzednicy != null && item.Liczba_porzadkowa != 1)
                {
                    foreach (var items in item.Poprzednicy)
                    {
                        pom.poczatek = items;
                        pom.koniec = item.Liczba_porzadkowa;
                        pom.waga = wagi[items];
                        krawedz.Add(pom);
                        pom = new Krawedz();
                    }
                }
            }
            pom.poczatek = 83;
            pom.koniec = 84;
            pom.waga = 14;
            krawedz.Add(pom);
            return krawedz;
        }
    }
}
