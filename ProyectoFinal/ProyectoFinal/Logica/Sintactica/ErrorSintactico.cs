using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class ErrorSintactico
    {
        public int filaError { get; set; }
        public String tokenEsperado { get; set; }

        public ErrorSintactico(int filaError, string tokenEsperado)
        {
            this.filaError = filaError;
            this.tokenEsperado = tokenEsperado;
        }
    }
}
