using Proyecto1.Logica.Sintactica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica
{
    public class AnalizadorSintactico
    {

        private List<Token> tokensAnalizar;
        private Token tokenActual;
        private Simbolo simboloActual;
        private int numeroTokenLista = 0;
        private ProduccionNoTerminal produccionNoTerminal;
        private ProduccionTerminal produccionTerminal;

        public AnalizadorSintactico()
        {
            produccionNoTerminal = new ProduccionNoTerminal();
            produccionTerminal = new ProduccionTerminal();
        }

        public void analizarCodigo()
        {
            simboloActual = new Simbolo("No_Terminal","PRI");
            tokenActual = solicitarToken(numeroTokenLista);

        }

        private Token solicitarToken(int posicion)
        {
            return tokensAnalizar.ElementAt(posicion);
        }
    }
}
