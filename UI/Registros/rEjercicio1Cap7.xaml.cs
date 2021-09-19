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
using System.Collections;

namespace Tarea3.UI.Registros
{
    /// <summary>
    /// Interaction logic for rEjercicio1Cap7.xaml
    /// </summary>
    public partial class rEjercicio1Cap7 : Window
    {
        public rEjercicio1Cap7()
        {
            InitializeComponent();
        }

        int Promedio = 0;
        int Suma = 0;

        int Minima = 10; // Las calificaciones son en base a 10 puntos
        int Maxima = 0;

        int CanEstudiantes = 0;
        int Calif = 0;

        ArrayList Calificaciones = new ArrayList();

        
        private void AddCalificacionButton_Click(object sender, RoutedEventArgs e)
        {
           

           Calif = Convert.ToInt32(CalificacionTexbox.Text); 
           Calificaciones.Add(Calif);

            CalificacionTexbox.Clear();
            
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            CanEstudiantes = Calificaciones.Count;

            foreach (int value in Calificaciones)
            {
                Suma += value;

                if (value < Minima)
                    Minima = value;

                if (value > Maxima)
                    Maxima = value;
            }

            Promedio = Suma / CanEstudiantes;

            PromedioTextbox.Text = Convert.ToString(Promedio);

            MinimaTextbox.Text = Convert.ToString(Minima);
            MaximaTextbox.Text = Convert.ToString(Maxima);
        }

        
    }
}
