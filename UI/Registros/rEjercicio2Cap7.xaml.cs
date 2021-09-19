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
    /// Interaction logic for rEjercicio2Cap7.xaml
    /// </summary>
    public partial class rEjercicio2Cap7 : Window
    {
        public rEjercicio2Cap7()
        {
            InitializeComponent();
        }

        string Palabra = "";
        string definicion = "";
        Hashtable Diccionario = new Hashtable();
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Palabra = PalabraTexbox.Text;
            

            if (Diccionario.ContainsKey(Palabra))
            {
                DefinicionTextbox.Text = (String)Diccionario[Palabra];
            }
            else
            {
                MessageBox.Show("Palabra no encontrada!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

        }
        
        private void AddPalabraButton_Click(object sender, RoutedEventArgs e)
        {           
            Palabra = PalabraTexbox.Text;
            definicion = DefinicionTextbox.Text;

            if (Diccionario.ContainsKey(Palabra))
            {
                MessageBox.Show("Esta palabra ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(PalabraTexbox.Text == "")
            {
                MessageBox.Show("El campo Palabra no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(DefinicionTextbox.Text == "")
            {
                MessageBox.Show("El campo definicion no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Diccionario.Add(Palabra, definicion);
            PalabraTexbox.Clear();
            DefinicionTextbox.Clear();
            PalabraTexbox.Focus();

            MessageBox.Show("La palabra fue añadida correctamente", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
