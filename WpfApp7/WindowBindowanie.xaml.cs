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
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Logika interakcji dla klasy WindowBindowanie.xaml
    /// </summary>
    public partial class WindowBindowanie : Window
    {
        public WindowBindowanie()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String wpisanyTekst = rozmiar.Text;
            MessageBox.Show("wpisany tekst " + wpisanyTekst,"okno informacyjne",
                MessageBoxButton.OK,MessageBoxImage.Exclamation);
        }
    }
}
