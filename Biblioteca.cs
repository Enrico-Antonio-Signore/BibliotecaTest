using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Verifica
{
    class Biblioteca
    {
        public List<Libro> listalibri;
        private string _nome;
        private string _indirizzo;
        private int _apertura;
        private int _chiusura;
        public Biblioteca(string nome, string indirizzo, int apertura,int chiusura)
        {
            listalibri = new List<Libro>();
            Nome = nome;
            Indirizzo = indirizzo;
            Apertura = apertura;
            Chiusura = chiusura;
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }
            set
            {
                _indirizzo = value;
            }
        }
        public int Apertura
        {
            get
            {
                return _apertura;
            }
            set
            {
                _apertura = value;
            }
        }
        public int Chiusura
        {
            get
            {
                return _chiusura;
            }
            set
            {
                _chiusura = value;
            }
        }
    }
}
