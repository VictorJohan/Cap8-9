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

namespace Cap8_9.UI.Capitulo8.Ejercicios8
{
    /// <summary>
    /// Interaction logic for Ejer5.xaml
    /// </summary>
    public partial class Ejer5 : Window
    {
        public Ejer5()
        {
            InitializeComponent();
        }

        private void OrdenarButton_Click(object sender, RoutedEventArgs e)
        {
            String cadena1 = Cadena1TextBox.Text, cadena2 = Cadena2TextBox.Text;
            int comparacion = String.Compare(cadena1, cadena2);
            
            if(comparacion == -1)
            {
                CadenaOrdenadaTextBlock.Text = $"{cadena1}\n{cadena2}";
            }
            else if(comparacion == 1)
            {
                CadenaOrdenadaTextBlock.Text = $"{cadena2}\n{cadena1}";

            }else if(comparacion == 0){
                CadenaOrdenadaTextBlock.Text = $"{cadena1}\n{cadena2}";
            }
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo8 capitulo8 = new Capitulo8();
            capitulo8.Show();
            this.Close();
        }
    }
}
