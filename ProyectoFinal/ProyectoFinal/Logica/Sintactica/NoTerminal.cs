using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class NoTerminal
    {
        public int valorFila { get; set; }
        public String nombreNoTerminal { get; set; }

        public NoTerminal(int valorFila, String nombreNoTerminal)
        {
            this.valorFila = valorFila;
            this.nombreNoTerminal = nombreNoTerminal;
        }
    }
}
