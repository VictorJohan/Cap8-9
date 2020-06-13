using Cap8_9.UI.Capitulo9.Ejercicios9;
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

namespace Cap8_9.UI.Capitulo9
{
    /// <summary>
    /// Interaction logic for Capitulo9.xaml
    /// </summary>
    public partial class Capitulo9 : Window
    {
        public Capitulo9()
        {
            InitializeComponent();
        }

        private void Ejer1Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer1 ejer1 = new Ejer1();
            ejer1.Show();

        }

        private void Ejer3Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer3 ejer3 = new Ejer3();
            ejer3.Show();
            this.Close();
        }

        private void Ejer4Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer4 ejer4 = new Ejer4();
            ejer4.Show();
            this.Close();
        }
    }
}
