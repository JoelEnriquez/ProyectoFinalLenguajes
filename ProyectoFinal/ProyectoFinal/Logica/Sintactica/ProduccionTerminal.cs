using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class ProduccionTerminal
    {
        private List<Terminal> listaTerminales;

        public ProduccionTerminal()
        {
            listaTerminales = new List<Terminal>();
            llenarLista();
        }
        private void llenarLista()
        {
            listaTerminales.Add(new Terminal(0, "TD"));
            listaTerminales.Add(new Terminal(1, "PR_Principal"));
            listaTerminales.Add(new Terminal(2, "Parentesis Apertura"));
            listaTerminales.Add(new Terminal(3, "Parentesis Cierre"));
            listaTerminales.Add(new Terminal(4, "Llave Apertura"));
            listaTerminales.Add(new Terminal(5, "Llave Cierre"));
            listaTerminales.Add(new Terminal(6, "Entero"));
            listaTerminales.Add(new Terminal(7, "Decimal"));
            listaTerminales.Add(new Terminal(8, "Char"));
            listaTerminales.Add(new Terminal(9, "Booleano"));
            listaTerminales.Add(new Terminal(10, "Cadena"));
            listaTerminales.Add(new Terminal(11, "Id"));
            listaTerminales.Add(new Terminal(12, "Operador Aritmetico Mas"));
            listaTerminales.Add(new Terminal(13, "Operador Aritmetico Menos"));
            listaTerminales.Add(new Terminal(14, "Operador Aritmetico Multi"));
            listaTerminales.Add(new Terminal(15, "Operador Aritmetico Division"));
            listaTerminales.Add(new Terminal(16, "Potencia"));
            listaTerminales.Add(new Terminal(17, "Coma"));
            listaTerminales.Add(new Terminal(18, "Fin Sentencia"));
            listaTerminales.Add(new Terminal(19, "Operador Logico NOT"));
            listaTerminales.Add(new Terminal(20, "Operador Relacional"));
            listaTerminales.Add(new Terminal(21, "Operador Logico"));
            listaTerminales.Add(new Terminal(22, "Operador Aritmetico Incre-Decre"));
            listaTerminales.Add(new Terminal(23, "PR_Imprimir"));
            listaTerminales.Add(new Terminal(24, "PR_Leer"));
            listaTerminales.Add(new Terminal(25, "PR_Mientras"));
            listaTerminales.Add(new Terminal(26, "PR_Hacer"));
            listaTerminales.Add(new Terminal(27, "PR_Si"));
            listaTerminales.Add(new Terminal(28, "PR_Sino_Si"));
            listaTerminales.Add(new Terminal(29, "PR_Sino"));
            listaTerminales.Add(new Terminal(30, "PR_Desde"));
            listaTerminales.Add(new Terminal(31, "PR_Hasta"));
            listaTerminales.Add(new Terminal(32, "PR_Incremento"));
            listaTerminales.Add(new Terminal(33, "Asignacion"));
        }

        public int retornarColumnaPorNombre(String nombreTerminal)
        {
            for (int i = 0; i < listaTerminales.Count; i++)
            {
                if (listaTerminales[i].nombreTerminal.Equals(nombreTerminal))
                {
                    return listaTerminales[i].valorColumna;
                }
            }
            return -1;
        }
    }
}
