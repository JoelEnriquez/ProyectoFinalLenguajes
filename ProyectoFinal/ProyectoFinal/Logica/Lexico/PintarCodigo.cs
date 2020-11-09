using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1.Logica
{
    public class PintarCodigo
    {
        private EditorCodigo editorCodigo;
        private List<Token> tokens;
        private int apuntadorTexto = 0;

        public PintarCodigo(EditorCodigo editorCodigo, List<Token> tokens)
        {
            this.editorCodigo = editorCodigo;
            this.tokens = tokens;
        }

        public void pintarCodigo()
        {
            RichTextBox ingresoCodigoRich = editorCodigo.GetRichTextBox();
            int index = ingresoCodigoRich.SelectionStart;

            for (int i = 0; i < tokens.Count; i++)
            {
                ingresoCodigoRich.Select(apuntadorTexto, tokens[i].posicionToken);
                ingresoCodigoRich.SelectionColor = colorToken(tokens[i].tipoToken);

                apuntadorTexto = tokens[i].posicionToken;
            }

            ingresoCodigoRich.SelectionStart = index;
            ingresoCodigoRich.SelectionLength = 0;
            editorCodigo.setRichTextBox(ingresoCodigoRich);
        }

        private Color colorToken(String tipoToken)
        {
            if (tipoToken.Equals("Operador Relacional") || tipoToken.Equals("Operador Logico") ||
               tipoToken.Equals("Signos de agrupacion") || tipoToken.Equals("Operador Aritmetico") ||
               tipoToken.Equals("Operador Logico NOT") || tipoToken.Equals("Potencia") ||
               tipoToken.Equals("Parentesis Apertura") || tipoToken.Equals("Parentesis Cierre") ||
               tipoToken.Equals("Llave Apertura") || tipoToken.Equals("Llave Cierre")) 

            {
                return Color.DarkBlue;
            }
            else if (tipoToken.Equals("Comentario"))
            {
                return Color.Red;
            }
            else if (tipoToken.Equals("Asignacion") || tipoToken.Equals("Fin Sentencia"))
            {
                return Color.Pink;
            }
            else if (tipoToken.Equals("Cadena"))
            {
                return Color.DarkGray;
            }
            else if (tipoToken.Equals("Entero"))
            {
                return Color.Purple;
            }
            else if (tipoToken.Equals("Char"))
            {
                return Color.Brown;
            }
            else if (tipoToken.Equals("Decimal"))
            {
                return Color.LightBlue;
            }
            else if (tipoToken.Equals("Booleano"))
            {
                return Color.Orange;
            }
            else if (tipoToken.Equals("Erroneo"))
            {
                return Color.DarkRed;
            }
            else if (tipoToken.Equals("Coma") || tipoToken.Equals("Id"))
            {
                return Color.Black;
            }
            if (tipoToken.Equals("TD") || tipoToken.Equals("PR_Si") ||
               tipoToken.Equals("PR_Sino") || tipoToken.Equals("PR_Sino_Si") ||
               tipoToken.Equals("PR_Mientras") || tipoToken.Equals("PR_Hacer") ||
               tipoToken.Equals("PR_Desde") || tipoToken.Equals("PR_Hasta") ||
               tipoToken.Equals("PR_Incremento") || tipoToken.Equals("PR_Principal"))
            {
                return Color.Green;
            }
            return Color.Transparent;
        }
    }
}
/*
 * ingresoCodigoRich.Select(apuntadorTexto, indiceCiclo);
            ingresoCodigoRich.SelectionColor = colorTexto;

            //Volver a deseleccionar el texto que ya esta pintado
            ingresoCodigoRich.SelectionStart = index;
            ingresoCodigoRich.SelectionLength = 0;
 * 
 * 
 */
