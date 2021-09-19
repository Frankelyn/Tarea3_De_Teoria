using System;
using System.Collections;
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
    /// Interaction logic for rEjercicio5Cap7.xaml
    /// </summary>
    public partial class rEjercicio5Cap7 : Window
    {
        public rEjercicio5Cap7()
        {
            InitializeComponent();
        }

        string Nombre = "";
        string Telefono = "";

        Hashtable Agenda = new Hashtable(); 
        private void AddContactoButton_Click(object sender, RoutedEventArgs e)
        {
            Nombre = NombreTexbox.Text;
            Telefono = TelefonoTextbox.Text;

            if(NombreTexbox.Text == "")
            {
                MessageBox.Show("El campo nombre no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(TelefonoTextbox.Text == "")
            {
                MessageBox.Show("El campo Telefono no puede estar vacio", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Agenda.ContainsKey(Nombre))
            {
                MessageBox.Show("Este contacto ya existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Agenda.Add(Nombre, Telefono);
            NombreTexbox.Clear();
            TelefonoTextbox.Clear();
            NombreTexbox.Focus();

            MessageBox.Show("Contacto agregado exitosamente!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Nombre = NombreTexbox.Text;

            if (Agenda.ContainsKey(Nombre))
            {
                TelefonoTextbox.Text = (String)Agenda[Nombre];
            }
            else
            {
                MessageBox.Show("Contacto no encontrado!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                TelefonoTextbox.Clear();
                NombreTexbox.Focus();

            }
        }

        
    }
}
