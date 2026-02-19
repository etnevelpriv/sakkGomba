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

namespace sakkGomba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string aktivBabu;
        double babuXPozicio;
        double babuYPozicio;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bastjaGomb_Click(object sender, RoutedEventArgs e)
        {
            aktivBabu = "bastja";
            jatekInditasa();
        }

        private void futoGomb_Click(object sender, RoutedEventArgs e)
        {
            aktivBabu = "futo";
            jatekInditasa();
        }

        private void huszarGomb_Click(object sender, RoutedEventArgs e)
        {
            aktivBabu = "huszar";
            jatekInditasa();
        }

        private void kiralynoGomb_Click(object sender, RoutedEventArgs e)
        {
            aktivBabu = "kiralyno";
            jatekInditasa();
        }

        private void jatekInditasa()
        {
            babuHatterBeallitasa();
            jatekGrid.Visibility = Visibility.Visible;
            menuGrid.Visibility = Visibility.Collapsed;
        }

        private void babuHatterBeallitasa()
        {
            var uri = new Uri($"pack://application:,,,/Images/{aktivBabu}.png", UriKind.Absolute);
            babu.Fill = new ImageBrush(new BitmapImage(uri))
            {
                Stretch = Stretch.Uniform,
                AlignmentX = AlignmentX.Center,
                AlignmentY = AlignmentY.Center
            };
        }

        private void checkBabuPozicio()
        {
            babuYPozicio = Canvas.GetTop(babu);
            babuXPozicio = Canvas.GetLeft(babu);
        }
    }
}