using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Logica
{
    public class AnalizadorLexico
    {
        private byte[] charAnalizar;
        private ManejadorCodigo manejador;
        private EditorCodigo editor;
        private Automata automata;
        private int estadoActual = 0;
        private int columnaAutomata = 0;
        private int apuntadorTexto = 0;
        private String auxTokenAceptado = "";
        private String auxCadenaMomentanea = "";
        private String auxRutaToken = "";
        private RichTextBox ingresoCodigoRich;
        private int fila = 1;
        private int columna = 1;

        public AnalizadorLexico(byte[] charAnalizar, ManejadorCodigo manejador, EditorCodigo editor)
        {
            this.charAnalizar = charAnalizar;
            this.manejador = manejador;
            this.editor = editor;
            this.ingresoCodigoRich = editor.GetRichTextBox();
            automata = new Automata();
        }

        public void ejecutarAnalizador()
        {
            for (int i = 0; i < charAnalizar.Length; i++)
            {
                int charActual = charAnalizar[i];

                moverColumnaFila(charActual);

                columnaAutomata = automata.devolverColumna(charActual, estadoActual); //Se obtiene la columna correspondiente al char

                int transicion = automata.retornarTransicion(estadoActual, columnaAutomata);
                //verifiar si la nueva transicion nos dirige a un estado de aceptacion

                if (transicion == -1) //No hay transicion valida
                {
                    if (automata.esEstadoAceptacion(estadoActual))
                    {
                        i--;
                    }
                    else { 
                        //si no hay cadena aceptada
                        if (estadoActual == 0)
                        {
                        //el token erroneo es el entrante
                        agregarTokenErroneoNuevo(Char.ToString((char)charActual), i+1);
                        }
                        else
                        {
                        String tokenErroneo = auxCadenaMomentanea.Substring(auxTokenAceptado.Length);
                        agregarTokenErroneoNuevo(tokenErroneo, i);
                            i--;//Volver a analizar el token entrante   
                        }
                    }
                    estadoActual = 0;
                    auxTokenAceptado = "";
                    auxCadenaMomentanea = "";
                    auxRutaToken = "";
                }
                else
                {
                    String cadenaTransicion = Char.ToString((char)charActual);

                    establecerRuta(transicion);
                    
                    //concatenar la cadena momentanea y proseguir al siguiente
                    auxCadenaMomentanea += cadenaTransicion;
                    if (automata.esEstadoAceptacion(transicion))
                    {
                        eliminarPosibleTokenRepetido(auxTokenAceptado);
                        auxTokenAceptado = auxCadenaMomentanea;

                        String tipoToken;
                        if (transicion == 5 || transicion == 8)
                        {
                            tipoToken = automata.devolverTipoToken(auxRutaToken);
                        }
                        else
                        {
                            tipoToken = automata.devolverPorEstado(transicion);
                            //es palabra reservada erronea
                            if (tipoToken.Equals("Palabra"))
                            {
                                tipoToken = automata.devolverTipoTokenPR(auxTokenAceptado);
                            }
                        }
                        agregarTokenAceptadoNuevo(tipoToken, i+1);
                    }
                    //Para el siguiente char, nos pasamos al siguiente estado
                    estadoActual = transicion;
                }
            }

            ////se verifica si hay una cadena aux restante, de ser asi, es porque no esta en un estado de aceptacion

            if (!automata.esEstadoAceptacion(estadoActual))
            {
                String ultimaCadenaErronea = auxCadenaMomentanea.Substring(auxTokenAceptado.Length);
                agregarTokenErroneoNuevo(ultimaCadenaErronea, charAnalizar.Length);
            }
        }


        /// <summary>
        /// Nos mueve entre la fila y la columna del texto
        /// </summary>
        /// <param name="charActual">El char actual</param>
        private void moverColumnaFila(int charActual)
        {
            
            if (charActual==10)
            {
                fila++;
                columna = 1;
            }
            else
            {
                columna++;
            }
        }

        private void establecerRuta(int transicion)
        {
            //Ruta del token para obtener luego el color si se llega a un estado de aceptacion
            if (estadoActual == 0)
            {
                auxRutaToken = columnaAutomata + "-" + transicion;
            }
            else
            {
                if (estadoActual != transicion)
                {
                    auxRutaToken += "," + columnaAutomata + "-" + transicion;
                }
            }
        }

        private void eliminarPosibleTokenRepetido(String ultimoTokenAceptado)
        {
            if (manejador.ultimoTokenIgual(ultimoTokenAceptado))
            {
                manejador.quitarTokenReciente();
            }
        }
        
        private void agregarTokenAceptadoNuevo(String tipoToken, int posicionToken)
        {
            manejador.agregarTokenNuevo(new Token(tipoToken, auxTokenAceptado, fila, columna, posicionToken));
        }

        private void agregarTokenErroneoNuevo(String tokenErroneo, int posicionToken)
        {
            manejador.agregarTokenNuevo(new Token("Erroneo", tokenErroneo, fila, columna, posicionToken));
        }
    }
}