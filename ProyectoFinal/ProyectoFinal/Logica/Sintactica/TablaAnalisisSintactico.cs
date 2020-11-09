using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica.Sintactica
{
    class TablaAnalisisSintactico
    {
        private int[,] tablaAnalisisSintactico = new int[41, 34];

        private object[] P0 = { Produccion.PRI };
        private object[] P1 = { Produccion.PRINCIPAL, Produccion.CODIGO};
        private object[] P2 = { "PR_Principal", "Parentesis Apertura", "Parentesis Cierre" };
        private object[] P3 = { "Llave Apertura", Produccion.C ,"Llave Cierre" };
        private object[] P4 = { Produccion.CODE, Produccion.C };
        private object[] P5 = { };
        private object[] P6 = { };
        private object[] P7 = { };
        private object[] P8 = { };
        private object[] P9 = { };
        private object[] P10 = { };
        private object[] P11 = { };
        private object[] P12 = { };
        private object[] P13 = { };
        private object[] P14 = { };
        private object[] P15 = { };
        private object[] P16 = { };
        private object[] P17 = { };
        private object[] P18 = { };
        private object[] P19 = { };

        public TablaAnalisisSintactico()
        {
            llenarTabla();
        }

        private void llenarTabla()
        {
            tablaAnalisisSintactico[0, 1] = 1; //PRINCIPAL CODIGO
            tablaAnalisisSintactico[1, 1] = 2; //principal ( )
            tablaAnalisisSintactico[2, 4] = 3; // { C }
            tablaAnalisisSintactico[3, 0] = 4; // CODE C
            tablaAnalisisSintactico[3, 5] = 0; //Epsilon
            tablaAnalisisSintactico[3, 11] = 4; // CODE C
            tablaAnalisisSintactico[3, 23] = 4; // CODE C
            tablaAnalisisSintactico[3, 24] = 4; // CODE C
            tablaAnalisisSintactico[3, 25] = 4; // CODE C
            tablaAnalisisSintactico[3, 26] = 4; // CODE C
            tablaAnalisisSintactico[3, 27] = 4; // CODE C
            tablaAnalisisSintactico[3, 30] = 4; // CODE C
            tablaAnalisisSintactico[4, 0] = 5; //DECLARAR_VAR
            tablaAnalisisSintactico[4, 11] = 6; //VAR_DECLARADA
            tablaAnalisisSintactico[4, 23] = 7; //IMPRI
            tablaAnalisisSintactico[4, 24] = 8; //LEER
            tablaAnalisisSintactico[4, 25] = 9; //WH
            tablaAnalisisSintactico[4, 26] = 10; //DWH
            tablaAnalisisSintactico[4, 27] = 11; //IF
            tablaAnalisisSintactico[4, 30] = 12; //FOR
            tablaAnalisisSintactico[5, 0] = 13; //TD BODY_VAR FIN_VAR
            tablaAnalisisSintactico[6, 11] = 14; //ID CHANGE_VALOR ;
            tablaAnalisisSintactico[7, 25] = 15; //MIENTRAS CONDICION CODIGO
            tablaAnalisisSintactico[8, 26] = 16; //HACER_BLOCK MIENTRAS_BLOCK
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[10, 30] = 18; //DESDE_BLOCK HASTA_BLOCK INCREMENTO_BLOCK
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
            tablaAnalisisSintactico[9, 27] = 17; //SI IF_BODY END_IF
        }
    }
}
