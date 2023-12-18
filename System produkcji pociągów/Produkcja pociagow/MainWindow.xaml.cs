using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new StronaStartowa();
        }

        private void Btn_pokaz_czynnosci(object sender, RoutedEventArgs e)
        {
            Main.Content = new Czynnosci();  
        }

        private void Btn_pokaz_kategorie(object sender, RoutedEventArgs e)
        {
            Main.Content = new Kategorie();
        }

        private void Btn_czas_produkcji(object sender, RoutedEventArgs e)
        {
            Main.Content = new CzasProdukcji();
        }
    }
}
