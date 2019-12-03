using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Helpers.Requests
{
    public class Pago
    {

        public string folio { get; set; }
        public string monto { get; set; }
        public string terminacionTarjeta { get; set; }
        public string fecha { get; set; }

    }
}
