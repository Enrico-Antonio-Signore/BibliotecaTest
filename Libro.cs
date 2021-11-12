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
        private int _pagine;
        public Libro(string nome, int pagine)
        {
            Nome = nome;
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
            string ore = "";
            if (x <= 100)
                ore = "Lettura pari ad un ora";
            if (x > 100 && x <= 200)
                ore = "Lettura pari a due ore";
            if (x > 200)
                ore = "Lettura superiore alle due ore";
            return ore;
        }
        public override string ToString()
        {
            return $"Nome: {_nome} Pagine: {_pagine}";
        }
    }
}
