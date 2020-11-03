using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto1.Logica
{
    public class ManejadorCodigo
    {
        private String codigoAnalizar;
        private AnalizadorLexico analizador;
        private EditorCodigo editor;
        private List<String> tokensInvalidos;
        private List<Token> tokensValidos;

        public ManejadorCodigo(EditorCodigo editor)
        {
            this.editor = editor;
            tokensInvalidos = new List<String>();
            tokensValidos = new List<Token>();
        }

        public void ejecutarManejador()
        {
            if (tokensInvalidos!=null)
            {
                tokensInvalidos.Clear();
                tokensValidos.Clear();
            }
            byte[] asciiBytes = Encoding.ASCII.GetBytes(codigoAnalizar);
            analizador = new AnalizadorLexico(asciiBytes,this,editor);
            analizador.ejecutarAnalizador();
        }

        public void recibirCodigo(String codigoAnalizar)
        {
            this.codigoAnalizar = codigoAnalizar;
        }

        public void agregarTokenErroneo(String token)
        {
            if (!token.Equals(""))
            {
                char posibleEspacioBlanco = token[0];
                if ((int)posibleEspacioBlanco != 9 && (int)posibleEspacioBlanco != 10 && (int)posibleEspacioBlanco != 32)
                {
                    tokensInvalidos.Add(token);
                }
            }    
        }

        public void agregarTokenCorrecto(Token tokenNuevo)
        {
            tokensValidos.Add(tokenNuevo);
        }

        public void eliminarPalabraInicialRepetida(String palabraAnterior)
        {
            tokensInvalidos.Remove(palabraAnterior);
        }

        public List<String> obtenerTokensInvalidos()
        {
            return tokensInvalidos;
        }

        
    }
}
