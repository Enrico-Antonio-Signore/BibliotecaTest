using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Verifica
{
    class Libro
    {
        private string _nome;
        private string _autore;
        private int _pagine;
        private string _ore;
        public Libro(string nome,string autore, int pagine)
        {
            Nome = nome;
            Autore = autore;
            Pagine = pagine;
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
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                _autore = value;
            }
        }
        public int Pagine
        {
            get
            {
                return _pagine;
            }
            set
            {
                _pagine = value;
            }
        }
        public string readingTime(int x)
        {
            _ore = "";
            if (x <= 100)
                _ore = "Lettura pari ad un ora";
            if (x > 100 && x <= 200)
                _ore = "Lettura pari a due ore";
            if (x > 200)
                _ore = "Lettura superiore alle due ore";
            return _ore;
        }
        public override string ToString()
        {
            return $"Nome: {_nome} Autore{_autore} Pagine: {_pagine}\nOre: {readingTime(_pagine)}";
        }
    }
}
