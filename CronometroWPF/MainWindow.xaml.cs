using System.Runtime.InteropServices;
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
using System.Windows.Threading;

namespace CronometroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICronometro cronometro;
        public MainWindow()
        {
            InitializeComponent();
            cronometro = Cronometro.Create(RefreshValue);
        }
        private void RefreshValue(object sender, EventArgs e)
        {
            cronometro.Avanza();
            txtSegundos.Text = cronometro.Segundos.ToString("00");
            txtMinutos.Text = cronometro.Minutos.ToString("00");
            txtHoras.Text = cronometro.Horas.ToString("00");

        }
        private void btnArrancar_Click(object sender, RoutedEventArgs e)
        {
            cronometro.Arrancar();
        }

        private void btnPausar_Click(object sender, RoutedEventArgs e)
        {
            cronometro.Pausar();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            cronometro.Stop();
            txtSegundos.Text = cronometro.Segundos.ToString("00");
            txtMinutos.Text = cronometro.Minutos.ToString("00");
            txtHoras.Text = cronometro.Horas.ToString("00");
        }
    }
}