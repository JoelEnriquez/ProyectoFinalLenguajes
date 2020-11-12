using Proyecto1.Logica.Sintactica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto1.Logica
{
    public class AnalizadorSintactico
    {

        private List<Token> tokensAnalizar;
        private List<ErrorSintactico> listaErrores;
        private Token tokenActual;
        private Simbolo simboloActual;
        private int numeroTokenLista = 0;
        private Simbolo[] simbolosSustituir;
        private ProduccionNoTerminal produccionNoTerminal;
        private ProduccionTerminal produccionTerminal;
        private ReglasProduccion reglasProduccion;
        private TablaAnalisisSintactico tablaAnalisis;
        private ManejadorCodigo manejador;
        private Pila pila;
        private int filaTabla;
        private int columnaTabla;
        private int reglaProduccionSeguir;
        private Boolean transicionInvalida = false;

        public AnalizadorSintactico(List<Token> tokensAnalizar)
        {
            produccionNoTerminal = new ProduccionNoTerminal();
            produccionTerminal = new ProduccionTerminal();
            reglasProduccion = new ReglasProduccion();
            tablaAnalisis = new TablaAnalisisSintactico();
            this.tokensAnalizar = tokensAnalizar;
            pila = new Pila();
            listaErrores = new List<ErrorSintactico>();
        }

        public void analizarCodigo()
        {
            tokensAnalizar.Add(new Token("Aceptacion","$",0,0,0));

            pila.agregarElemento(new Simbolo("Terminal","Aceptacion"));
            pila.agregarElemento(new Simbolo("No_Terminal", "PRI"));

            while ((pila.sizePila() > 0 || tokensAnalizar.Count > 0 ) && !transicionInvalida)
            {
                simboloActual = pila.ultimoElemento();
                tokenActual = tokensAnalizar[0];

                if (simboloActual.tipoSimbolo.Equals("No_Terminal"))
                {
                    solicitarTransicion();
                    if (reglaProduccionSeguir != -1)
                    {
                        simbolosSustituir = reglasProduccion.retornarProduccion(reglaProduccionSeguir);
                        shift(simbolosSustituir);                      
                    }
                    else
                    {
                        listaErrores.Add(new ErrorSintactico(tokenActual.fila, simboloActual.contenido));
                        transicionInvalida = true;
                    }
                }
                else
                {
                    if (simboloActual.contenido.Equals(tokenActual.tipoToken))
                    {
                        reduce();
                    }
                    else if (simboloActual.contenido.Equals("Epsilon"))
                    {
                        pila.EliminarUltimoElemento();
                    }
                    else
                    {
                        listaErrores.Add(new ErrorSintactico(tokenActual.fila, simboloActual.contenido));
                        transicionInvalida = true;
                    }
                }
            }
        }

        private Token solicitarToken()
        {
            return tokensAnalizar[0];
        }

        private void solicitarTransicion()
        {
            try
            {
                filaTabla = produccionNoTerminal.retornarFilaPorNombre(simboloActual.contenido);
                columnaTabla = produccionTerminal.retornarColumnaPorNombre(tokenActual.tipoToken);
                reglaProduccionSeguir = tablaAnalisis.devolverIntProduccion(filaTabla, columnaTabla);   
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void shift(Simbolo[] simbolosSustituir)
        {
            pila.EliminarUltimoElemento();
            //Se ingresan los simbolos nuevos a la pila
            for (int i = simbolosSustituir.Length-1; i >= 0; i--)
            {
                pila.agregarElemento(simbolosSustituir[i]);
            }

        }

        private void reduce()
        {
            pila.EliminarUltimoElemento();
            tokensAnalizar.RemoveAt(0);
        }

        private Token solicitarToken(int posicion)
        {
            return tokensAnalizar.ElementAt(posicion);
        }

        public List<ErrorSintactico> getListaErrores()
        {
            return listaErrores;
        }
    }
}
