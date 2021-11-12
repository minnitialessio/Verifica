using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime OrarioApertura { set; get; }
        private DateTime OrarioChiusura { set; get; }
        public List<Libro> Libri { set; get; }

        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura, List<Libro> libri)
        {
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Nome = nome;
            Indirizzo = indirizzo;
            Libri = libri;
        }

        public void AggiungiLibro(Libro libro)
        {
            Libri.Add(libro);
        }

        public Libro RicercaLibroDaTitolo(string titolo)
        {
            foreach(Libro l in Libri)
            {
                if(l.Titolo == titolo)
                {
                    return l;
                }
            }
            throw new Exception("libro inesistente");
        }

        public int NumeroLibriPresenti()
        {
            return Libri.Count;
        }
        public List<Libro> RicercaLibriAutore(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();

            foreach(Libro l in Libri)
            {
                if(l.Autore == autore)
                {
                    libriAutore.Add(l);
                }
            }
            return libriAutore;
        }
        public string Nome
        {
            set
            {
                if (value == null)
                    throw new Exception("stringa vuota");
                _nome = value;
            }
            get
            {
                return _nome;
            }
        }
        public string Indirizzo
        {
            set
            {
                if (value == null)
                    throw new Exception("stringa vuota");
                _indirizzo = value;
            }
            get
            {
                return _indirizzo;
            }
        }

        public override string ToString()
        {
            return Nome + " " + Indirizzo + " " + OrarioApertura + " " + OrarioChiusura;
        }
    }
}
