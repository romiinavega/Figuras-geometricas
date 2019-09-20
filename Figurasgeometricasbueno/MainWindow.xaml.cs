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

namespace Figuras_geometricas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAreaR_Click(object sender, RoutedEventArgs e)
        {
            int numero1 =
                  int.Parse(Rnum1.Text);
            int numero2 =
                int.Parse(Rnum2.Text);
            int resultado =
                numero1 * numero2;
            lblResultadoR.Text = resultado.ToString();

        }

        private void BtnAreaT_Click(object sender, RoutedEventArgs e)
        {
            int numero1 =
                  int.Parse(Tnum1.Text);
            int numero2 =
                int.Parse(Tnum2.Text);
            int resultado =
                numero1 * numero2 / 2;
            lblResultadoT.Text = resultado.ToString();
        }

        private void BtnAreaC_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                  double.Parse(Cnum1.Text);
            double resultado =
                numero1 * numero1 * 3.1416;
            lblResultadoC.Text = resultado.ToString();
        }

        private void ButtonTr_Click(object sender, RoutedEventArgs e)
        {
            double numero1 =
                 double.Parse(num1tr.Text);
            double numero2 =
                double.Parse(num2tr.Text);
            double numero3 =
                double.Parse(num3tr.Text);

            double resultado =
               (numero1 + numero2) * numero3 / 2;
            lblResultadoTr.Text = resultado.ToString();
        }
    }
}

