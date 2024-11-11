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
        private bool isPogrubienieUsed = false;
        private bool isKursywaUsed = false;
        private bool isPodkreslenieUsed = false;
        private bool isCzerwonyUsed = false;
        private bool isZielonyUsed = false;
        private bool isNiebieskiUsed = false;
        private bool isArialUsed = false;
        private bool isCalibriUsed = false;
        private bool isTimesNewRomanUsed = false;
        private bool isRozmiarUsed = false;
        private bool isLeftAlignUsed = false;
        private bool isCenterAlignUsed = false;
        private bool isRightAlignUsed = false;
        private bool isJustifyUsed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChbPogrubienie_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.FontWeight = ChbPogrubienie.IsChecked == true ? FontWeights.Bold : FontWeights.Normal;
            if (!isPogrubienieUsed)
            {
                isPogrubienieUsed = true;
                UpdateProgress();
            }
        }

        private void ChbKursywa_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.FontStyle = ChbKursywa.IsChecked == true ? FontStyles.Italic : FontStyles.Normal;
            if (!isKursywaUsed)
            {
                isKursywaUsed = true;
                UpdateProgress();
            }
        }

        private void ChbPodkreslenie_Checked(object sender, RoutedEventArgs e)
        {
            txtTekst.TextDecorations = ChbPodkreslenie.IsChecked == true ? TextDecorations.Underline : null;
            if (!isPodkreslenieUsed)
            {
                isPodkreslenieUsed = true;
                UpdateProgress();
            }
        }

        private void CzerwonyKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (CzerwonyKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Red;
                if (!isCzerwonyUsed)
                {
                    isCzerwonyUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void ZielonyKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (ZielonyKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Green;
                if (!isZielonyUsed)
                {
                    isZielonyUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void NiebieskiKolor_Checked(object sender, RoutedEventArgs e)
        {
            if (NiebieskiKolor.IsChecked == true)
            {
                txtTekst.Foreground = Brushes.Blue;
                if (!isNiebieskiUsed)
                {
                    isNiebieskiUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void ArialCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (ArialCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Arial");
                if (!isArialUsed)
                {
                    isArialUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void CalibriCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (CalibriCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Calibri");
                if (!isCalibriUsed)
                {
                    isCalibriUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void TimesNewRomanCzcionka_Checked(object sender, RoutedEventArgs e)
        {
            if (TimesNewRomanCzcionka.IsChecked == true)
            {
                txtTekst.FontFamily = new FontFamily("Times New Roman");
                if (!isTimesNewRomanUsed)
                {
                    isTimesNewRomanUsed = true;
                    UpdateProgress();
                }
            }
        }

        private void SuwakRozmiarCzcionki_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtTekst.FontSize = SuwakRozmiarCzcionki.Value;
            if (!isRozmiarUsed && SuwakRozmiarCzcionki.Value > SuwakRozmiarCzcionki.Minimum)
            {
                isRozmiarUsed = true;
                UpdateProgress();
            }
        }

        private void WyrownajDoLewej_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Left;
            if (!isLeftAlignUsed)
            {
                isLeftAlignUsed = true;
                UpdateProgress();
            }
        }

        private void WyrownajDoSrodka_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Center;
            if (!isCenterAlignUsed)
            {
                isCenterAlignUsed = true;
                UpdateProgress();
            }
        }

        private void WyrownajDoPrawej_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Right;  // Tak często używam angielskiego że czasami zapominam że mam takie rzeczy po polsku pisać na lekcje tylko ja ten kod tak długo robie już że nie chce mi sie czegokolwiek zmieniać lub dodawać :D
            if (!isRightAlignUsed)
            {
                isRightAlignUsed = true;
                UpdateProgress();
            }
        }

        private void WyrownajJustowanie_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.TextAlignment = TextAlignment.Justify;
            if (!isJustifyUsed)                                                                                                                                                                         // I will bring you JUSTICE!
            {
                isJustifyUsed = true;
                UpdateProgress();
            }
        }

        private void UpdateProgress() 
        {
            if (PasekPostepu != null) // Przez jakieś 15-30 minut próbuje znaleść sposób żeby jeden każdy postęp do paska postępu dawał jeden prostokąt zamiast kilku na raz ale nici z tego
            {
                int count = 0;
                if (isPogrubienieUsed) count++;
                if (isKursywaUsed) count++;
                if (isPodkreslenieUsed) count++;
                if (isCzerwonyUsed) count++;
                if (isZielonyUsed) count++;
                if (isNiebieskiUsed) count++;
                if (isArialUsed) count++;
                if (isCalibriUsed) count++;
                if (isTimesNewRomanUsed) count++;
                if (isRozmiarUsed) count++;
                if (isLeftAlignUsed) count++;
                if (isCenterAlignUsed) count++;
                if (isRightAlignUsed) count++;
                if (isJustifyUsed) count++;

                PasekPostepu.Value = (double)count / 14 * 100;
            }
        }
    }
}
