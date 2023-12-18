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
using System.Xml;

namespace Produkcja_Pociagow
{
    /// <summary>
    /// Logika interakcji dla klasy Czynnosci.xaml
    /// </summary>
    public partial class Czynnosci : Page
    {
        public Czynnosci()
        {
            InitializeComponent();
            List<Czynnosc> czynnosci = new List<Czynnosc>();
            Czynnosc.PobierzCzynnosczPliku(czynnosci);
            foreach (var item in czynnosci)
            {
                ListaCzynnosci.Text += Czynnosc.PokazCzynnosc(item);
            }
        }

    }
}
