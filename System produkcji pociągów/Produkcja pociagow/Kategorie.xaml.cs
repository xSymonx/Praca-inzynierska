using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Logika interakcji dla klasy Kategorie.xaml
    /// </summary>
    public partial class Kategorie : Page
    {
        public Kategorie()
        {
            InitializeComponent();
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);

            Przycisk1.Content = Kategoria.PobierzNazweKategorii(kategorie[0]);
            Przycisk2.Content = Kategoria.PobierzNazweKategorii(kategorie[1]);
            Przycisk3.Content = Kategoria.PobierzNazweKategorii(kategorie[2]);
            Przycisk4.Content = Kategoria.PobierzNazweKategorii(kategorie[3]);
            Przycisk5.Content = Kategoria.PobierzNazweKategorii(kategorie[4]);
            Przycisk6.Content = Kategoria.PobierzNazweKategorii(kategorie[5]);
            Przycisk7.Content = Kategoria.PobierzNazweKategorii(kategorie[6]);
            Przycisk8.Content = Kategoria.PobierzNazweKategorii(kategorie[7]);
            Przycisk9.Content = Kategoria.PobierzNazweKategorii(kategorie[8]);
            Przycisk10.Content = Kategoria.PobierzNazweKategorii(kategorie[9]);
            Przycisk11.Content = Kategoria.PobierzNazweKategorii(kategorie[10]);
            Przycisk12.Content = Kategoria.PobierzNazweKategorii(kategorie[11]);
            Przycisk13.Content = Kategoria.PobierzNazweKategorii(kategorie[12]);
            Przycisk14.Content = Kategoria.PobierzNazweKategorii(kategorie[13]);
        }

        private void Przycisk1_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[0]);
        }
        private void Przycisk2_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[1]);
        }
        private void Przycisk3_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[2]);
        }
        private void Przycisk4_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[3]);
        }
        private void Przycisk5_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[4]);
        }
        private void Przycisk6_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[5]);
        }
        private void Przycisk7_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[6]);
        }
        private void Przycisk8_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[7]);
        }
        private void Przycisk9_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[8]);
        }
        private void Przycisk10_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[9]);
        }
        private void Przycisk11_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[10]);
        }
        private void Przycisk12_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[11]);
        }
        private void Przycisk13_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[12]);
        }
        private void Przycisk14_Click(object sender, RoutedEventArgs e)
        {
            List<Kategoria> kategorie = new List<Kategoria>();
            Kategoria.PobierzKategorieZPliku(kategorie);
            ListaCzynnosciWKategorii.Text = Kategoria.PokazCzynnosciWKategorii(kategorie[13]);
        }
    }
}
