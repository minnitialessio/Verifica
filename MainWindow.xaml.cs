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
    //Commento di prova
        Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            Libro libro1 = new Libro("Martin","Game of Thrones",2016,"Mondadori",240);
            Libro libro2 = new Libro("J.K Rowling","Harry Potter",2000, "Mondadori",202);
            Libro libro3 = new Libro("Neil Gaiman","Sandman",1998, "Mondadori",300);
            List<Libro> libri = new List<Libro>();
            libri.Add(libro1);
            libri.Add(libro2);
            libri.Add(libro3);
            biblioteca = new Biblioteca("malatestiana", "via emilia", DateTime.Now, DateTime.Now,libri);
            lstLibriBiblioteca.ItemsSource = null;
            lstLibriBiblioteca.ItemsSource = biblioteca.Libri;
        }

        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titolo = txtTitoloLibro.Text;
                string autore = txtAutoreLibro.Text;
                int numeroPagine = int.Parse(txtNumeroPagine.Text);
                int anno = int.Parse(txtAnno.Text);
                string editore = txtEditore.Text;
                Libro libro = new Libro(autore, titolo, anno, editore, numeroPagine);
                biblioteca.Libri.Add(libro);
                lstLibriBiblioteca.ItemsSource = null;
                lstLibriBiblioteca.ItemsSource = biblioteca.Libri;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcolaNumeroLibri_Click(object sender, RoutedEventArgs e)
        {
            int numeroLibri = biblioteca.NumeroLibriPresenti();
            MessageBox.Show(numeroLibri.ToString());
        }

        private void btnRicercaLibroDaTitolo_Click(object sender, RoutedEventArgs e)
        {
            string titolo = txtTitolo.Text;
            Libro libro = biblioteca.RicercaLibroDaTitolo(titolo);
            txtLibro.Text = libro.ToString();
        }

        private void btnRicercaLibriAutore_Click(object sender, RoutedEventArgs e)
        {
            string autore = txtAutore.Text;
            List<Libro> libriAutore = biblioteca.RicercaLibriAutore(autore);
            lstLibri.ItemsSource = null;
            lstLibri.ItemsSource = libriAutore;
        }

        private void txtAutore_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnRicercaLibriAutore.IsEnabled = true;
        }

        private void txtTitolo_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnRicercaLibroDaTitolo.IsEnabled = true;
        }

        private void btnReadingTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro l = lstLibriBiblioteca.SelectedItem as Libro;
                string readingTime = l.ReadingTime();
                MessageBox.Show(readingTime);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
