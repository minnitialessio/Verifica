using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        public string Autore { set; get; }
        public string Titolo { set; get; }
        public int AnnoPubblicazione { set; get; }
        public string Editore { set; get; }
        public int NumeroPagine { set; get; }

        public override string ToString()
        {
            return Autore + " " + Titolo + " " + AnnoPubblicazione + " " + Editore + " " + NumeroPagine;
        }
    }
}
