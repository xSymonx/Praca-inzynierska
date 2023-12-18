using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Produkcja_Pociagow
{
    /// <summary>
    /// Logika interakcji dla klasy CzasProdukcji.xaml
    /// </summary>
    public partial class CzasProdukcji : Page
    {
        public CzasProdukcji()
        {
            InitializeComponent();
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            List<int> czas = new List<int>();
            Planowanie_Produkcji planowanie_produkcji = new Planowanie_Produkcji();
            int idx_poczatkowy = 1;
            int idx_koncowy = 84;
            bool pamiec = false;
            int[] d = Planowanie_Produkcji.CzasProdukcji(idx_poczatkowy, idx_koncowy);
            czas.Add(d[idx_koncowy]);
            foreach (var item in kategorie)
            {
                idx_poczatkowy = Kategoria.PobierzIndexPierwszejCzynnosci(item);
                idx_koncowy = Kategoria.PobierzIndexOstatniejCzynnosci(item) + 1;

                if (pamiec == true)
                {
                    czas.Add(d[idx_koncowy] - d[idx_poczatkowy]);
                    czas.Add(d[idx_koncowy] - d[idx_poczatkowy]);
                    pamiec = false;
                }
                else if (d[idx_poczatkowy] == d[idx_koncowy])
                {
                    pamiec = true;
                }
                else
                {
                    czas.Add(d[idx_koncowy] - d[idx_poczatkowy]);
                }
            }
            int i = 0;
            CzasProdukcjiLokomotywy.Text += "Czas_Produkcji produkcji gotowej lokomotywy - " + czas[i++] + " dni." + "\n";
            foreach (var item in kategorie)
            {
                CzasProdukcjiLokomotywy.Text += Kategoria.PobierzNazweKategorii(item) + " - " + czas[i++] + " dni." + "\n";
            }
        }

    }
   
}
