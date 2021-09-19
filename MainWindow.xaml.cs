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
using Tarea3.UI.Registros;

namespace Tarea3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio1Cap6MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio1Cap6 rEjercicio1Cap6 = new rEjercicio1Cap6();
            rEjercicio1Cap6.Show();

            rEjercicio1Cap6.CantidadEstudiantesTexbox.IsEnabled = false;
            rEjercicio1Cap6.AddCalificacionButton.IsEnabled = false;
            rEjercicio1Cap6.CalcularButton.IsEnabled = false;


        }

        private void Ejercicio1Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio1Cap7 rEjercicio1Cap7 = new rEjercicio1Cap7();
            rEjercicio1Cap7.Show();
        }

        private void Ejercicio2Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio2Cap7 rEjercicio2Cap7 = new rEjercicio2Cap7();
            rEjercicio2Cap7.Show();
        }

        private void Ejercicio5Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEjercicio5Cap7 rEjercicio5Cap7 = new rEjercicio5Cap7();
            rEjercicio5Cap7.Show();
        }
    }
}
