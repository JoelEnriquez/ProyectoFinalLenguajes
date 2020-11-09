using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Logica
{
    class PalabraReservada
    {
        public String palabraReservada { get; set; }
        public String tipoToken { get; set; }

        public PalabraReservada(string palabraReservada, string tipoToken)
        {
            this.palabraReservada = palabraReservada;
            this.tipoToken = tipoToken;
        }
    }
}
