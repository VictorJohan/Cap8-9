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
using Cap8_9.UI.Capitulo8;
using Cap8_9.UI.Capitulo9;

namespace Cap8_9
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

        private void Capitulo8Button_Click(object sender, RoutedEventArgs e)
        {
            Capitulo8 capitulo8 = new Capitulo8();
            capitulo8.Show();
            this.Close();
        }

        private void Capitulo9Button_Click(object sender, RoutedEventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9();
            capitulo9.Show();
            this.Close();
        }
    }
}
