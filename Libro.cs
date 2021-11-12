using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        public string Autore {
            set
            {
                if (value == null)
                    throw new Exception("stringa vuota");
                _autore = value;
            }
            get
            {
                return _autore;
            }
        }
        public string Titolo { 
            set
            {
                if (value == null)
                    throw new Exception("stringa vuota");
                _titolo = value;
            }
            get
            {
                return _titolo;
            }
        }
        private int _annoPubblicazione;
        public int AnnoPubblicazione { 
            set 
            {
                if (value <= 0)
                    throw new Exception("valore non valido");
                _annoPubblicazione = value;
            }
            get
            {
                return _annoPubblicazione;
            } 
        }
        private string _editore;
        public string Editore {
            set
            {
                if (value == null)
                    throw new Exception("stringa vuota");
                _editore = value;
            }
            get
            {
                return _editore;
            }
        }
        private int _numeroPagine;
        public int NumeroPagine {
            set
            {
                if (value <= 0)
                    throw new Exception("valore non valido");
                _numeroPagine = value;
            }
            get
            {
                return _numeroPagine;
            }
        }

        public Libro(string autore, string titolo, int numeroPagine, string editore, int annoPubblicazione)
        {
            AnnoPubblicazione = annoPubblicazione;
            Autore = autore;
            NumeroPagine = numeroPagine;
            Titolo = titolo;
            Editore = editore;
        }


        public string ReadingTime()
        {
            string readingTimeOre;

            if(NumeroPagine < 100)
            {
                readingTimeOre = "1h";
            }
            else if(NumeroPagine >= 100 && NumeroPagine <= 200)
            {
                readingTimeOre = "2h";
            }
            else
            {
                readingTimeOre = "più di 2h";
            }

            return readingTimeOre;
        }
        public override string ToString()
        {
            return Autore + " " + Titolo + " anno pubblicazione: " + AnnoPubblicazione + " editore: " + Editore + " numero pagine: " + NumeroPagine;
        }
    }
}
