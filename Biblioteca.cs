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

        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura)
        {
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Nome = nome;
            Indirizzo = indirizzo;
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
