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
    /// Interaction logic for Ejer3.xaml
    /// </summary>
    public partial class Ejer3 : Window
    {
        public Ejer3()
        {
            InitializeComponent();
            MostrarHoraFecha();
        }

        public void MostrarHoraFecha()
        {
            FechaHoraLabel.Content += DateTime.Now.ToString();
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo8 capitulo8 = new Capitulo8();
            capitulo8.Show();
            this.Close();
        }
    }
}
