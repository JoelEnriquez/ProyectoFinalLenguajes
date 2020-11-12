using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class ProduccionNoTerminal
    {
        private List<NoTerminal> listaNoTerminales;

        public ProduccionNoTerminal()
        {
            listaNoTerminales = new List<NoTerminal>();
            llenarLista();
        }

        private void llenarLista()
        {
            listaNoTerminales.Add(new NoTerminal(0, "PRI"));
            listaNoTerminales.Add(new NoTerminal(1, "PRINCIPAL"));
            listaNoTerminales.Add(new NoTerminal(2, "CODIGO"));
            listaNoTerminales.Add(new NoTerminal(3, "C"));
            listaNoTerminales.Add(new NoTerminal(4, "CODE"));
            listaNoTerminales.Add(new NoTerminal(5, "DECLARAR_VAR"));
            listaNoTerminales.Add(new NoTerminal(6, "VAR_DECLARADA"));
            listaNoTerminales.Add(new NoTerminal(7, "WH"));
            listaNoTerminales.Add(new NoTerminal(8, "DWH"));
            listaNoTerminales.Add(new NoTerminal(9, "IF"));
            listaNoTerminales.Add(new NoTerminal(10, "FOR"));
            listaNoTerminales.Add(new NoTerminal(11, "IMPRI"));
            listaNoTerminales.Add(new NoTerminal(12, "LEER"));
            listaNoTerminales.Add(new NoTerminal(13, "BODY_IMPRI"));
            listaNoTerminales.Add(new NoTerminal(14, "FIN_IMPRI"));
            listaNoTerminales.Add(new NoTerminal(15, "BODY_LEER"));
            listaNoTerminales.Add(new NoTerminal(16, "CONDICION"));
            listaNoTerminales.Add(new NoTerminal(17, "HACER_BLOCK"));
            listaNoTerminales.Add(new NoTerminal(18, "MIENTRAS_BLOCK"));
            listaNoTerminales.Add(new NoTerminal(19, "IF_BODY"));
            listaNoTerminales.Add(new NoTerminal(20, "END_IF"));
            listaNoTerminales.Add(new NoTerminal(21, "DESDE_BLOCK"));
            listaNoTerminales.Add(new NoTerminal(22, "HASTA_BLOCK"));
            listaNoTerminales.Add(new NoTerminal(23, "INCREMENTO_BLOCK"));
            listaNoTerminales.Add(new NoTerminal(24, "BODY_VAR"));
            listaNoTerminales.Add(new NoTerminal(25, "ASIG"));
            listaNoTerminales.Add(new NoTerminal(26, "FIN_VAR"));
            listaNoTerminales.Add(new NoTerminal(27, "CHANGE_VALOR"));
            listaNoTerminales.Add(new NoTerminal(28, "VALOR"));
            listaNoTerminales.Add(new NoTerminal(29, "CONDI"));
            listaNoTerminales.Add(new NoTerminal(30, "NOT"));
            listaNoTerminales.Add(new NoTerminal(31, "CONDI_BODY"));
            listaNoTerminales.Add(new NoTerminal(32, "CONDI2"));
            listaNoTerminales.Add(new NoTerminal(33, "SEG_DATO"));
            listaNoTerminales.Add(new NoTerminal(34, "M"));
            listaNoTerminales.Add(new NoTerminal(35, "SUMA"));
            listaNoTerminales.Add(new NoTerminal(36, "P"));
            listaNoTerminales.Add(new NoTerminal(37, "MULTI"));
            listaNoTerminales.Add(new NoTerminal(38, "S"));
            listaNoTerminales.Add(new NoTerminal(39, "POTENCIA"));
            listaNoTerminales.Add(new NoTerminal(40, "ASIG_VALOR"));
        }

        public int retornarFilaPorNombre(String nombreNoTerminal)
        {
            for (int i = 0; i < listaNoTerminales.Count; i++)
            {
                if (listaNoTerminales[i].nombreNoTerminal.Equals(nombreNoTerminal))
                {
                    return listaNoTerminales[i].valorFila;
                }
            }
            return -1;
        }
    }
}
