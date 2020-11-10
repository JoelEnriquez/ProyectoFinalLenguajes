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
        

        public TablaAnalisisSintactico()
        {
            llenarEstadosErroneos();
            llenarTabla();
        }

        private void llenarEstadosErroneos()
        {
            for (int i = 0; i < tablaAnalisisSintactico.GetLength(0); i++)
            {
                for (int j = 0; j < tablaAnalisisSintactico.GetLength(1); j++)
                {
                    tablaAnalisisSintactico[i, j] = -1;
                }
            }
        }

        private void llenarTabla()
        {
            tablaAnalisisSintactico[0, 1] = 1; // PRINCIPAL CODIGO
            tablaAnalisisSintactico[1, 1] = 2; // principal ( )
            tablaAnalisisSintactico[2, 4] = 3; // { C }
            tablaAnalisisSintactico[3, 0] = 4; // CODE C
            tablaAnalisisSintactico[3, 5] = 0; // Epsilon
            tablaAnalisisSintactico[3, 11] = 4; // CODE C
            tablaAnalisisSintactico[3, 23] = 4; // CODE C
            tablaAnalisisSintactico[3, 24] = 4; // CODE C
            tablaAnalisisSintactico[3, 25] = 4; // CODE C
            tablaAnalisisSintactico[3, 26] = 4; // CODE C
            tablaAnalisisSintactico[3, 27] = 4; // CODE C
            tablaAnalisisSintactico[3, 30] = 4; // CODE C
            tablaAnalisisSintactico[4, 0] = 5; // DECLARAR_VAR
            tablaAnalisisSintactico[4, 11] = 6; // VAR_DECLARADA
            tablaAnalisisSintactico[4, 23] = 7; // IMPRI
            tablaAnalisisSintactico[4, 24] = 8; // LEER
            tablaAnalisisSintactico[4, 25] = 9; // WH
            tablaAnalisisSintactico[4, 26] = 10; // DWH
            tablaAnalisisSintactico[4, 27] = 11; // IF
            tablaAnalisisSintactico[4, 30] = 12; // FOR
            tablaAnalisisSintactico[5, 0] = 13; // TD BODY_VAR FIN_VAR
            tablaAnalisisSintactico[6, 11] = 14; // ID CHANGE_VALOR ;
            tablaAnalisisSintactico[7, 25] = 15; // MIENTRAS CONDICION CODIGO
            tablaAnalisisSintactico[8, 26] = 16; // HACER_BLOCK MIENTRAS_BLOCK
            tablaAnalisisSintactico[9, 27] = 17; // SI IF_BODY END_IF
            tablaAnalisisSintactico[10, 30] = 18; // DESDE_BLOCK HASTA_BLOCK INCREMENTO_BLOCK
            tablaAnalisisSintactico[11, 23] = 19; // imprimir BODY_IMPRI
            tablaAnalisisSintactico[12, 24] = 20; // leer BODY_LEER ;
            tablaAnalisisSintactico[13, 2] = 21; // ( VALOR FIN_IMPRI
            tablaAnalisisSintactico[14, 3] = 22; // ) ;
            tablaAnalisisSintactico[14, 12] = 23; // + VALOR FIN_IMPRI
            tablaAnalisisSintactico[15, 2] = 24; // ( ID )
            tablaAnalisisSintactico[16, 2] = 25; // ( CONDI )
            tablaAnalisisSintactico[17, 26] = 26; // HACER CODIGO
            tablaAnalisisSintactico[18, 25] = 27; // MIENTRAS CONDICION ;
            tablaAnalisisSintactico[19, 2] = 28; // CONDICION CODIGO
            tablaAnalisisSintactico[20, 0] = 0; // Epsilon
            tablaAnalisisSintactico[20, 5] = 0; // Epsilon
            tablaAnalisisSintactico[20, 11] = 0; // Epsilon
            tablaAnalisisSintactico[20, 23] = 0; // Epsilon
            tablaAnalisisSintactico[20, 24] = 0; // Epsilon
            tablaAnalisisSintactico[20, 25] = 0; // Epsilon
            tablaAnalisisSintactico[20, 26] = 0; // Epsilon
            tablaAnalisisSintactico[20, 27] = 0; // Epsilon
            tablaAnalisisSintactico[20, 28] = 29; // SINO_SI IF_BODY END_IF
            tablaAnalisisSintactico[20, 29] = 30; // SINO CODIGO
            tablaAnalisisSintactico[20, 30] = 0; // Epsilon
            tablaAnalisisSintactico[21, 30] = 31; // DESDE DECLARAR_VAR
            tablaAnalisisSintactico[22, 31] = 32; // HASTA CONDI
            tablaAnalisisSintactico[23, 32] = 33; // INCREMENTO ENTERO CODIGO
            tablaAnalisisSintactico[24, 11] = 34; // ID ASIG
            tablaAnalisisSintactico[25, 17] = 0; // Epsilon
            tablaAnalisisSintactico[25, 18] = 0; // Epsilon
            tablaAnalisisSintactico[25, 33] = 35; // = VALOR
            tablaAnalisisSintactico[26, 17] = 36; // , BODY_VAR FIN_VAR
            tablaAnalisisSintactico[26, 18] = 37; // ;
            tablaAnalisisSintactico[27, 22] = 38; // OP_INCRE_DECRE
            tablaAnalisisSintactico[27, 33] = 35; // = VALOR
            tablaAnalisisSintactico[28, 2] = 39; // M SUMA
            tablaAnalisisSintactico[28, 6] = 39; // M SUMA
            tablaAnalisisSintactico[28, 7] = 39; // M SUMA
            tablaAnalisisSintactico[28, 8] = 39; // M SUMA
            tablaAnalisisSintactico[28, 9] = 39; // M SUMA
            tablaAnalisisSintactico[28, 10] = 39; // M SUMA
            tablaAnalisisSintactico[28, 11] = 39; // M SUMA
            tablaAnalisisSintactico[28, 13] = 39; // M SUMA
            tablaAnalisisSintactico[29, 3] = 0; // Epsilon
            tablaAnalisisSintactico[29, 19] = 40; // NOT CONDI_BODY CONDI2
            tablaAnalisisSintactico[29, 32] = 0; // Epsilon
            tablaAnalisisSintactico[30, 2] = 0; // Epsilon
            tablaAnalisisSintactico[30, 6] = 0; // Epsilon
            tablaAnalisisSintactico[30, 7] = 0; // Epsilon
            tablaAnalisisSintactico[30, 8] = 0; // Epsilon
            tablaAnalisisSintactico[30, 9] = 0; // Epsilon
            tablaAnalisisSintactico[30, 10] = 0; // Epsilon
            tablaAnalisisSintactico[30, 11] = 0; // Epsilon
            tablaAnalisisSintactico[30, 13] = 0; // Epsilon
            tablaAnalisisSintactico[30, 19] = 41; // OLN
            tablaAnalisisSintactico[31, 2] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 6] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 7] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 8] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 9] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 10] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 11] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[31, 13] = 42; // VALOR SEG_DATO
            tablaAnalisisSintactico[32, 3] = 0; // Epsilon
            tablaAnalisisSintactico[32, 21] = 43; // OL CONDI_BODY CONDI2
            tablaAnalisisSintactico[32, 32] = 0; // Epsilon
            tablaAnalisisSintactico[33, 3] = 0; // Epsilon
            tablaAnalisisSintactico[33, 20] = 44; // OR NOT VALOR
            tablaAnalisisSintactico[33, 21] = 0; // Epsilon
            tablaAnalisisSintactico[33, 32] = 0; // Epsilon
            tablaAnalisisSintactico[34, 2] = 45; // P MULTI
            tablaAnalisisSintactico[34, 6] = 45; // P MULTI
            tablaAnalisisSintactico[34, 7] = 45; // P MULTI
            tablaAnalisisSintactico[34, 8] = 45; // P MULTI
            tablaAnalisisSintactico[34, 9] = 45; // P MULTI
            tablaAnalisisSintactico[34, 10] = 45; // P MULTI
            tablaAnalisisSintactico[34, 11] = 45; // P MULTI
            tablaAnalisisSintactico[34, 13] = 45; // P MULTI
            tablaAnalisisSintactico[35, 3] = 0; // Epsilon
            tablaAnalisisSintactico[35, 12] = 46; // + M SUMA
            tablaAnalisisSintactico[35, 13] = 47; // - M SUMA
            tablaAnalisisSintactico[35, 17] = 0; // Epsilon
            tablaAnalisisSintactico[35, 18] = 0; // Epsilon
            tablaAnalisisSintactico[35, 20] = 0; // Epsilon
            tablaAnalisisSintactico[35, 21] = 0; // Epsilon
            tablaAnalisisSintactico[35, 22] = 0; // Epsilon
            tablaAnalisisSintactico[35, 32] = 0; // Epsilon
            tablaAnalisisSintactico[35, 33] = 0; // Epsilon
            tablaAnalisisSintactico[36, 2] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 6] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 7] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 8] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 9] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 10] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 11] = 48; // S POTENCIA
            tablaAnalisisSintactico[36, 13] = 48; // S POTENCIA
            tablaAnalisisSintactico[37, 3] = 0; // Epsilon
            tablaAnalisisSintactico[37, 12] = 0; // Epsilon
            tablaAnalisisSintactico[37, 13] = 0; // Epsilon
            tablaAnalisisSintactico[37, 14] = 49; // * P MULTI
            tablaAnalisisSintactico[37, 15] = 50; // / P MULTI
            tablaAnalisisSintactico[37, 17] = 0; // Epsilon
            tablaAnalisisSintactico[37, 18] = 0; // Epsilon
            tablaAnalisisSintactico[37, 20] = 0; // Epsilon
            tablaAnalisisSintactico[37, 21] = 0; // Epsilon
            tablaAnalisisSintactico[37, 22] = 0; // Epsilon
            tablaAnalisisSintactico[37, 32] = 0; // Epsilon
            tablaAnalisisSintactico[37, 33] = 0; // Epsilon
            tablaAnalisisSintactico[38, 2] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 6] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 7] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 8] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 9] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 10] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 11] = 51; // ASIG_VALOR
            tablaAnalisisSintactico[38, 13] = 52; // - ASIG_VALOR
            tablaAnalisisSintactico[39, 3] = 0; // Epsilon
            tablaAnalisisSintactico[39, 12] = 0; // Epsilon
            tablaAnalisisSintactico[39, 13] = 0; // Epsilon
            tablaAnalisisSintactico[39, 14] = 0; // Epsilon
            tablaAnalisisSintactico[39, 15] = 0; // Epsilon
            tablaAnalisisSintactico[39, 16] = 53; // ^ P
            tablaAnalisisSintactico[39, 17] = 0; // Epsilon
            tablaAnalisisSintactico[39, 18] = 0; // Epsilon
            tablaAnalisisSintactico[39, 20] = 0; // Epsilon
            tablaAnalisisSintactico[39, 21] = 0; // Epsilon
            tablaAnalisisSintactico[39, 22] = 0; // Epsilon
            tablaAnalisisSintactico[39, 32] = 0; // Epsilon
            tablaAnalisisSintactico[39, 33] = 0; // Epsilon
            tablaAnalisisSintactico[40, 2] = 54; // ( VALOR )
            tablaAnalisisSintactico[40, 6] = 55; // ENTERO
            tablaAnalisisSintactico[40, 7] = 56; // DECIMAL
            tablaAnalisisSintactico[40, 8] = 57; // CHAR
            tablaAnalisisSintactico[40, 9] = 58; // BOOLEANO
            tablaAnalisisSintactico[40, 10] = 59; // CADENA
            tablaAnalisisSintactico[40, 11] = 60; // ID
        }

        public int devolverIntProduccion(int noTerminal, int terminal)
        {
            return tablaAnalisisSintactico[noTerminal, terminal];
        }
    }
}
