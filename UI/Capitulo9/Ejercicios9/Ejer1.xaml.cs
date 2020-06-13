using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    /// Interaction logic for Ejer1.xaml
    /// </summary>
    public partial class Ejer1 : Window
    {
        public struct Producto
        {
           public int IdProducto;
           public string Nombre;
           public int CantidadProducto;
           public double PrecioProducto;
        }
        Producto producto = new Producto();

        public Ejer1()
        {
            InitializeComponent();
        }

        private void GuardarYMostrarButton_Click(object sender, RoutedEventArgs e)
        {
            producto.IdProducto = int.Parse(IdProductoTextBox.Text);
            producto.Nombre = NombreProductoTextBox.Text;
            producto.CantidadProducto = int.Parse(CantidadProductoTextBox.Text);
            producto.PrecioProducto = double.Parse(PrecioProductoTextBox.Text);

            Limpiar();
            Mostrar();
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo9 capitulo9 = new Capitulo9();
            capitulo9.Show();
            this.Close();
        }

        public void Limpiar()
        {
            IdProductoTextBox.Text = "";
            NombreProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
            PrecioProductoTextBox.Text = "";
        }

        public void Mostrar()
        {
            ViewTextBlock.Text = $"Id Producto:\n{producto.IdProducto}\nNombre Producto:\n{producto.Nombre}\n" +
                $"Cantidad Producto:\n{producto.CantidadProducto}\nPrecio producto:\n{producto.PrecioProducto}";
        }
    }
}
