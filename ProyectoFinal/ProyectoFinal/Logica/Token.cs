﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica
{
    class Token
    {
        public String tipoToken { get; set; }
        public String contenido { get; set; }
        public int fila { get; set; }
        public int columna { get; set; }

        public Token(string tipoToken, string contenido, int fila, int columna)
        {
            this.tipoToken = tipoToken;
            this.contenido = contenido;
            this.fila = fila;
            this.columna = columna;
        }
    }
}