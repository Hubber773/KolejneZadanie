using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KolejneZadanie
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChbPogrubienie_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.FontWeight = ChbPogrubienie.IsChecked == true ? FontWeights.Bold : FontWeights.Normal;
        }

        private void ChbKursywa_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.FontStyle = ChbKursywa.IsChecked == true ? FontStyles.Italic : FontStyles.Normal;
        }

        private void ChbPodkreslenie_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.TextDecorations = ChbPodkreslenie.IsChecked == true ? TextDecorations.Underline : null;
        }

        private void CzerwonyKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (CzerwonyKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Red;
            }
        }

        private void ZielonyKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (ZielonyKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Green;
            }
        }

        private void NiebieskiKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (NiebieskiKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Blue;
            }
        }

        private void ArialCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (ArialCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Arial");
            }
        }

        private void CalibriCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (CalibriCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Calibri");
            }
        }

        private void TimesNewRomanCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (TimesNewRomanCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Times New Roman");
            }
        }

        private void SuwakRozmiarCzcionki_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtTekst.FontSize = SuwakRozmiarCzcionki.Value;
        }

        private void WyrownajDoLewej_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Left;
        }

        private void WyrownajDoSrodka_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Center;
        }

        private void WyrownajDoPrawej_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Right;
        }

        private void Wyrownaj_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Justify;
        }
    }
}
