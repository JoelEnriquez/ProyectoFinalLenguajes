using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    public class ReglasProduccion
    {

        private List<Simbolo[]> reglasSimbolos;

        public ReglasProduccion()
        {
            reglasSimbolos = new List<Simbolo[]>();
            llenarLista();
        }

        public void llenarLista()
        {
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal","Epsilon")}); //0
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal","PRINCIPAL"), new Simbolo("No_Terminal","CODIGO")}); //1
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Principal"), new Simbolo("Terminal", "Parentesis Apertura"), new Simbolo("Terminal", "Parentesis Cierre") }); //2
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Llave Apertura"), new Simbolo("No_Terminal", "C"), new Simbolo("Terminal", "Llave Cierre") }); //3
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "CODE"), new Simbolo("No_Terminal", "C") }); //4
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "DECLARAR_VAR") }); //5
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "VAR_DECLARADA") }); //6
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "IMPRI") }); //7
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "LEER") }); //8
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "WH") }); //9
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "DWH") }); //10
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "IF") }); //11
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "FOR") }); //12
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "TD"), new Simbolo("No_Terminal", "BODY_VAR"), new Simbolo("No_Terminal", "FIN_VAR") }); //13
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Id"), new Simbolo("No_Terminal", "CHANGE_VALOR"), new Simbolo("Terminal", "Fin Sentencia") }); //14
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Mientras"), new Simbolo("No_Terminal", "CONDICION"), new Simbolo("No_Terminal", "CODIGO") }); //15
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "HACER_BLOCK"), new Simbolo("No_Terminal", "MIENTRAS_BLOCK") }); //16
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Si"), new Simbolo("No_Terminal", "IF_BODY"), new Simbolo("No_Terminal", "END_IF") }); //17
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "DESDE_BLOCK"), new Simbolo("No_Terminal", "HASTA_BLOCK"), new Simbolo("No_Terminal", "INCREMENTO_BLOCK") }); //18
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Imprimir"), new Simbolo("No_Terminal", "BODY_IMPRI") }); //19
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Leer"), new Simbolo("No_Terminal", "BODY_LEER"), new Simbolo("Terminal", "Fin Sentencia") }); //20
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Parentesis Apertura"), new Simbolo("No_Terminal", "VALOR"), new Simbolo("No_Terminal", "FIN_IMPRI") }); //21
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Parentesis Cierre"), new Simbolo("Terminal", "Fin Sentencia") }); //22
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Mas"), new Simbolo("No_Terminal", "VALOR"), new Simbolo("Terminal", "FIN_IMPRI") }); //23
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Parentesis Apertura"), new Simbolo("Terminal", "Id"), new Simbolo("Terminal", "Parentesis Cierre") }); //24
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "LParentesis Apertura"), new Simbolo("No_Terminal", "CONDI"), new Simbolo("Terminal", "Parentesis Cierre") }); //25
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Hacer"), new Simbolo("No_Terminal", "CODIGO")}); //26
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Mientras"), new Simbolo("No_Terminal", "CONDICION"), new Simbolo("Terminal", "Fin Sentencia") }); //27
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "CONDICION"), new Simbolo("No_Terminal", "CODIGO") }); //28
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Sino_Si"), new Simbolo("No_Terminal", "IF_BODY"), new Simbolo("No_Terminal", "END_IF") }); //29
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Sino"), new Simbolo("No_Terminal", "CODIGO")}); //30
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Desde"), new Simbolo("No_Terminal", "DECLARAR_VAR")}); //31
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Hasta"), new Simbolo("No_Terminal", "CONDI")}); //32
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "PR_Incremento"), new Simbolo("Terminal", "Entero"), new Simbolo("No_Terminal", "CODIGO") }); //33
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Id"), new Simbolo("No_Terminal", "ASIG")}); //34
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Asignacion"), new Simbolo("No_Terminal", "VALOR")}); //35
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Coma"), new Simbolo("No_Terminal", "BODY_VAR"), new Simbolo("No_Terminal", "FIN_VAR") }); //36
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Fin Sentencia")}); //37
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Incre-Decre") }); //38
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "M"), new Simbolo("No_Terminal", "SUMA")}); //39
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "NOT"), new Simbolo("No_Terminal", "CONDI_BODY"), new Simbolo("No_Terminal", "CONDI2") }); //40
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Logico NOT") }); //41
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "VALOR"), new Simbolo("No_Terminal", "SEG_DATO") }); //42
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Logico"), new Simbolo("No_Terminal", "CONDI_BODY"), new Simbolo("No_Terminal", "CONDI2") }); //43
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Relacional"), new Simbolo("No_Terminal", "NOT"), new Simbolo("No_Terminal", "VALOR") }); //44
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "P"), new Simbolo("No_Terminal", "MULTI") }); //45
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Mas"), new Simbolo("No_Terminal", "M"), new Simbolo("No_Terminal", "SUMA") }); //46
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Menos"), new Simbolo("No_Terminal", "M"), new Simbolo("No_Terminal", "SUMA") }); //47
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "S"), new Simbolo("No_Terminal", "POTENCIA") }); //48
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Division"), new Simbolo("No_Terminal", "P"), new Simbolo("No_Terminal", "MULTI") }); //49
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Multi"), new Simbolo("No_Terminal", "P"), new Simbolo("No_Terminal", "MULTI") }); //50
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("No_Terminal", "ASIG_VALOR") }); //51
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Operador Aritmetico Menos"), new Simbolo("No_Terminal", "ASIG_VALOR") }); //52
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Potencia"), new Simbolo("No_Terminal", "P") }); //53
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Parentesis Apertura"), new Simbolo("No_Terminal", "VALOR"), new Simbolo("Terminal", "Parentesis Apertura") }); //54
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Entero")}); //55
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Decimal") }); //56
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Char") }); //57
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Booleano") }); //58
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Cadena") }); //59
            reglasSimbolos.Add(new Simbolo[] { new Simbolo("Terminal", "Id")}); //60

        }

        public Simbolo[] retornarProduccion(int posicion)
        {
            return reglasSimbolos.ElementAt(posicion);
        }


    }
}
