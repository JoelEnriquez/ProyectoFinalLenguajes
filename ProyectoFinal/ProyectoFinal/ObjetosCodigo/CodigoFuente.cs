using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.ObjetosCodigo
{
    [Serializable]
    public class CodigoFuente
    {
        private String nombreCodigoFuente;
        private String codigo;

        public CodigoFuente(String nombreCodigoFuente)
        {
            this.nombreCodigoFuente = nombreCodigoFuente;
            codigo = "";
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public String getNombreCodigo()
        {
            return nombreCodigoFuente;
        }



    }
}
