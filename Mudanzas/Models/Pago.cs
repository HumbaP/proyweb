using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Models
{
    public class Pago
    {
         public Pago()
        {
            this.folio = folio;
            this.monto = monto;
            this.terminacionTarjeta = terminacionTarjeta;
            this.estatus = estatus;
            this.fecha = fecha;
        }
        public int folio { get; set; }
        public double monto { get; set; }
        public string terminacionTarjeta { get; set; }
        public string estatus { get; set; }
        public DateTime fecha { get; set; }
    }
}
