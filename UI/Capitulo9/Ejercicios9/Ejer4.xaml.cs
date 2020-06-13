using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cap8_9.UI.Capitulo9.Ejercicios9
{
    /// <summary>
    /// Interaction logic for Ejer4.xaml
    /// </summary>
    public partial class Ejer4 : Window
    {
        //NO PUDE ENTEDER QUE ERA LO QUE SE ME ESTABA PIDIENDO EXACTAMETE DESPUDE CREAR LA ENUMERACION.
        enum Neumatico {Verano , Invierno, Allseasons, Asimétricos, Direccionales, Antipinchazos, Tweel};
        public Ejer4()
        {
            InitializeComponent();
        }

        private void InsertarButton_Click(object sender, RoutedEventArgs e)
        {
            Neumatico neumatico;

            neumatico = Neumatico.Direccionales;
            TipoTextBox.Text = neumatico.ToString();
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9();
            capitulo9.Show();
            this.Close();
        }
    }
}
