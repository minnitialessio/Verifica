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

namespace Biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            Libro libro1 = new Libro("Martin","Game of Thrones",2016,"Mondadori",240);
            Libro libro2 = new Libro("J.K Rowling","Harry Potter",2000, "Mondadori",202);
            Libro libro3 = new Libro("Autore3","Sherlock Holmes",1998, "Mondadori",300);
            List<Libro> libri = new List<Libro>();
            libri.Add(libro1);
            libri.Add(libro2);
            libri.Add(libro3);
            biblioteca = new Biblioteca("malatestiana", "via emilia", DateTime.Now, DateTime.Now,libri);
        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalcolaNumeroLibri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRicercaLibroDaTitolo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRicercaLibriAutore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtAutore_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnRicercaLibriAutore.IsEnabled = true;
        }

        private void txtTitolo_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnRicercaLibroDaTitolo.IsEnabled = true;
        }
    }
}
