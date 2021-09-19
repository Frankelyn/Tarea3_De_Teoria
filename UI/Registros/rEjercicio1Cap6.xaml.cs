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

namespace Tarea3.UI.Registros
{
    /// <summary>
    /// Interaction logic for rEjercicio1Cap6.xaml
    /// </summary>
    public partial class rEjercicio1Cap6 : Window
    {
        public rEjercicio1Cap6()
        {
            InitializeComponent();
        }


        int CanSalones = 0;
        int CanEstudiantes = 0;

        string valor = "";

        float Promedio = 0.0f;
        float Suma = 0.0f;

        float Maxima = 0.0f;
        float Minima = 10.0f;

        int totalEstudiantes = 0;

        float[][] Calificaciones;

        bool ok = true;

        //Variable para añadir indice del contenedor del jagged
        int n = 0;

        bool b1 = true; //Variable bandera para habilitar el CalificacionTextbox
        bool b2 = true; // Variable bandera para habilitar el cantidadEstudiantesTextbox
        bool b4 = false; // Variable bandera para saltar el incremento de i por primera vez
        private void AddSalonButton_Click(object sender, RoutedEventArgs e)
        {
            if(SalonesTexbox.Text == "")
            {
                MessageBox.Show("El campo Cantidad de salones no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ok)
            {
                CanSalones = Convert.ToInt32(SalonesTexbox.Text);
                Calificaciones = new float[CanSalones][];
                SalonesTexbox.IsEnabled = false;
                ok = false;
            }

            if (b2)
            {
                AddCalificacionButton.IsEnabled = true;
                CalcularButton.IsEnabled = true;
                CantidadEstudiantesTexbox.IsEnabled = true;
                b2 = false;
            }

            CantidadEstudiantesTexbox.IsEnabled = true;
            CantidadEstudiantesTexbox.Clear();
            CantidadEstudiantesTexbox.Focus();
            AddCalificacionButton.IsEnabled = true;
           


            if (b4)
            {
                i++;
            }

            b4 = true;
            b1 = true;

        }

        //Variables para añadir elementos al arreglo jagged
        int i = 0;
        int j = 0;
        


        private void AddCalificacionButton_Click(object sender, RoutedEventArgs e)
        {
            if(CantidadEstudiantesTexbox.Text == "")
            {
                MessageBox.Show("El campo Cantidad de Estudiantes no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(CalificacionTexbox.Text == "")
            {
                MessageBox.Show("El campo Calificacion no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            CantidadEstudiantesTexbox.IsEnabled = false;
            AddSalonButton.IsEnabled = false;
            

            if (b1)
            {
                CanEstudiantes = Convert.ToInt32(CantidadEstudiantesTexbox.Text);
                Calificaciones[n] = new float[CanEstudiantes];
                n++;
                j = 0;
                totalEstudiantes += CanEstudiantes;
                b1 = false;
            }
                                    
            if (n == CanSalones)
                AddSalonButton.IsEnabled = false;



            if (j < Calificaciones[i].GetLength(0))
            {
                Calificaciones[i][j] = Convert.ToSingle(CalificacionTexbox.Text);
                CalificacionTexbox.Clear();
                CalificacionTexbox.Focus();
                j++;
            }
      
            if (j == Calificaciones[i].GetLength(0))
            {
                AddCalificacionButton.IsEnabled = false;

                if (n!= CanSalones)
                {
                    AddSalonButton.IsEnabled = true;
                }

                
                CantidadEstudiantesTexbox.Focus();
                
            }
            
             


        }

        

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {                                  
            valor = Convert.ToString(CalcularPromedio(Calificaciones));

            PromedioTextbox.Text = valor;

            valor = Convert.ToString(MenorCalificacion(Calificaciones));
            MinimaTextbox.Text = valor;

            valor = Convert.ToString(MayorCalificacion(Calificaciones));
            MaximaTextbox.Text = valor;



        }


        public float CalcularPromedio(float[][] arreglo)
        {
            
            for (int i = 0; i < CanSalones; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    Suma += arreglo[i][j];
                                      
                }
            }

            Promedio = Suma / totalEstudiantes;

            return Promedio;

            

            
        }


        public float MenorCalificacion(float [][] arreglo)
        {
            for (int i = 0; i < CanSalones; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    if (arreglo[i][j] < Minima)
                        Minima = arreglo[i][j];
                }
            }

            return Minima;
        }

        public float MayorCalificacion(float[][] arreglo)
        {
            for (int i = 0; i < CanSalones; i++)
            {
                for (int j = 0; j < arreglo[i].Length; j++)
                {
                    if (arreglo[i][j] > Maxima)
                        Maxima = Calificaciones[i][j];
                }
            }

            return Maxima;
        }
    }
}
