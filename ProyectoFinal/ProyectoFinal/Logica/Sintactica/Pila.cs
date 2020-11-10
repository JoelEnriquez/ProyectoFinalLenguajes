using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class Pila
    {
        private List<Simbolo> pilaSimbolos;

        public Pila()
        {
            pilaSimbolos = new List<Simbolo>();
        }

        public void agregarElemento(Simbolo simboloNuevo)
        {
            pilaSimbolos.Add(simboloNuevo);
        }

        public void limpiarLista()
        {
            pilaSimbolos.Clear();
        }

        public Simbolo ultimoElemento()
        {
            return pilaSimbolos.Last();
        }

        public int sizePila()
        {
            return pilaSimbolos.Count;
        }

        public void EliminarUltimoElemento()
        {
            pilaSimbolos.RemoveAt(pilaSimbolos.Count - 1);
        }

        public Simbolo elementoPosicion(int posicion)
        {
            return pilaSimbolos.ElementAt(posicion);
        }


    }
}
