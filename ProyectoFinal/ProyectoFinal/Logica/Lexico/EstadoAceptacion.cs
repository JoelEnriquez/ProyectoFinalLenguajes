using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica
{
    public class EstadoAceptacion
    {
        public int numeroEstado { get; set; }
        public String tipoToken { get; set; }
        public String caminoAceptacion { get; set; }

        public EstadoAceptacion(int numeroEstado, string tipoToken)
        {
            this.numeroEstado = numeroEstado;
            this.tipoToken = tipoToken;
        }

        public EstadoAceptacion(int numeroEstado, string tipoToken, string caminoAceptacion)
        {
            this.numeroEstado = numeroEstado;
            this.tipoToken = tipoToken;
            this.caminoAceptacion = caminoAceptacion;
        }
    }
}
