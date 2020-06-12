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
using Cap8_9.UI.Capitulo8.Ejercicios8;

namespace Cap8_9.UI.Capitulo8
{
    /// <summary>
    /// Interaction logic for Capitulo8.xaml
    /// </summary>
    public partial class Capitulo8 : Window
    {
        public Capitulo8()
        {
            InitializeComponent();
        }

        private void Ejer3Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer3 ejer3 = new Ejer3();
            ejer3.Show();
            this.Close();
        }

        private void Ejer5Button_Click(object sender, RoutedEventArgs e)
        {
            Ejer5 ejer5 = new Ejer5();
            ejer5.Show();
            this.Close();
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
