using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class Simbolo
    {
        public String tipoSimbolo { get; set; }
        public String contenido { get; set; }

        public Simbolo(string tipoSimbolo, string contenido)
        {
            this.tipoSimbolo = tipoSimbolo;
            this.contenido = contenido;
        }
    }
}
