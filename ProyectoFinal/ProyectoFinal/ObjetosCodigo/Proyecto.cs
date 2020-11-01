using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.ObjetosCodigo
{
    [Serializable]
    public class Proyecto
    {
        
        private ArrayList codigoFuentes;

        public Proyecto()
        {
            codigoFuentes = new ArrayList();
        }

        public void agregarCodigoFuente(CodigoFuente codigo)
        {
            codigoFuentes.Add(codigo);
        }

        /// <summary>
        /// Busca el nombre de codigo y devulve su contenido
        /// </summary>
        /// <param name="nombreCodigo"></param>
        /// <returns></returns>
        public String devolverCodigoFuente(String nombreCodigo)
        {
            for (int i = 0; i < codigoFuentes.Count; i++)
            {
                if (((CodigoFuente)codigoFuentes[i]).getNombreCodigo().Equals(nombreCodigo))
                {
                    return ((CodigoFuente)codigoFuentes[i]).getCodigo();
                }
            }
            return "";
        }

        public void setearCodigo(String nombreCodigo, String codigo)
        {
            for (int i = 0; i < codigoFuentes.Count; i++)
            {
                if (((CodigoFuente)codigoFuentes[i]).getNombreCodigo().Equals(nombreCodigo))
                {
                    ((CodigoFuente)codigoFuentes[i]).setCodigo(codigo);
                }
            }
        }
        
        public ArrayList getCodigoFuentes()
        {
            return codigoFuentes;
        }
    }
}
