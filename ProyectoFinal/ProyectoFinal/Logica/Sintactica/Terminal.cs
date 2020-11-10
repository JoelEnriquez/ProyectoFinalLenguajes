using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class Terminal
    {
        public int valorColumna { get; set; }
        public String nombreTerminal { get; set; }

        public Terminal(int valorColumna, String nombreTerminal)
        {
            this.valorColumna = valorColumna;
            this.nombreTerminal = nombreTerminal;
        }
    }
}
