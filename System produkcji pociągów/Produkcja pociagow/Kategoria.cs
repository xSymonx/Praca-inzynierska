using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Produkcja_Pociagow
{
    public class Kategoria
    {
        private int Index_pierwszej_czynnosci { get; set; }
        private int Index_ostatniej_czynnosci { get; set; }
        private string Nazwa_kategorii { get; set; }

        public Kategoria() { }

        public static void PobierzKategorieZPliku(List<Kategoria> kategorie)
        {
            string zmienna_pom;
            int index_wystapienia;
            string zmienna_tymczas;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\szymo\OneDrive\Desktop\Kategorie Praca Inzynierska.csv");
            Kategoria kategoria = new Kategoria();
            //Czynnosci.Add(new Czynnosc() { Czas_Produkcji = 0, Nazwa = null, Liczba_porzadkowa = 0, Poprzednicy = null });

            for (int i = 1; i < 15; i++)
            {

                zmienna_pom = lines[i] + " ";
                index_wystapienia = zmienna_pom.IndexOf(';');
                zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                kategoria.Nazwa_kategorii = zmienna_tymczas;
                zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);

                index_wystapienia = zmienna_pom.IndexOf(';');
                zmienna_tymczas = zmienna_pom.Substring(0, index_wystapienia);
                kategoria.Index_pierwszej_czynnosci = int.Parse(zmienna_tymczas);
                zmienna_pom = zmienna_pom.Remove(0, index_wystapienia + 1);

                kategoria.Index_ostatniej_czynnosci = int.Parse(zmienna_pom);

                kategorie.Add(kategoria);
                kategoria = new Kategoria();
            }
        }
        public static string PobierzNazweKategorii(Kategoria kategoria)
        {
            return kategoria.Nazwa_kategorii;
        }
        public static int PobierzIndexPierwszejCzynnosci(Kategoria kategoria)
        {
            return kategoria.Index_pierwszej_czynnosci;
        }
        public static int PobierzIndexOstatniejCzynnosci(Kategoria kategoria)
        {
            return kategoria.Index_ostatniej_czynnosci;
        }
        public static string PokazCzynnosciWKategorii(Kategoria kategoria)
        {
            List<Czynnosc> czynnosci = new List<Czynnosc>();
            Czynnosc.PobierzCzynnosczPliku(czynnosci);

            int k = kategoria.Index_pierwszej_czynnosci;
            int j = kategoria.Index_ostatniej_czynnosci;
            string lines = "";

            for (int i = k; i <= j; i++)
            {
                lines += i + ". " + Czynnosc.PobierzNazweCzynnosci(czynnosci[i]) + '\n';
            }
            return lines;
        }
    }
}
