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
        private List<Token> listaTokens;

        public ManejadorCodigo(EditorCodigo editor)
        {
            this.editor = editor;
            tokensInvalidos = new List<String>();
            listaTokens = new List<Token>();
        }

        public void ejecutarManejador()
        {
            if (tokensInvalidos!=null)
            {
                tokensInvalidos.Clear();
                listaTokens.Clear();
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

        public void pintarCodigo()
        {
            PintarCodigo pintarCodigo = new PintarCodigo(editor, listaTokens);
            pintarCodigo.pintarCodigo();
        }

        public void agregarTokenNuevo(Token tokenNuevo)
        {
            listaTokens.Add(tokenNuevo);
        }

        public void quitarTokenReciente()
        {
            listaTokens.RemoveAt(listaTokens.Count-1);
        }

        public Boolean ultimoTokenIgual(String contenidoUltimoToken)
        {
            if (numeroTokens()>0 && listaTokens[numeroTokens()-1].contenido.Equals(contenidoUltimoToken))
            {
                return true;
            }
            return false;
        }

        public int numeroTokens()
        {
            return listaTokens.Count;
        }

        public List<Token> obtenerTokensInvalidos()
        {
            List<Token> tokensInvalidos = new List<Token>();
            for (int i = 0; i < numeroTokens(); i++)
            {
                if (listaTokens[i].tipoToken.Equals("Erroneo"))
                {
                    tokensInvalidos.Add(listaTokens[i]);
                }
            }
            return tokensInvalidos;
        }

        
    }
}
