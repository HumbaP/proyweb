using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Models
{
    public class Sede
    {
        public Sede(int id, string alias, string ciudad, string estado, double latitud, double longitud, string tipoSede, int pertenece)
        {
            this.id = id;
            this.alias = alias;
            this.ciudad = ciudad;
            this.estado = estado;
            this.latitud = latitud;
            this.longitud = longitud;
            this.tipoSede = tipoSede;
            this.pertenece = pertenece;
        }
        private int id { get; set; }
        private string alias { get; set; }
        private string ciudad { get; set; }
        private string estado { get; set; }
        private double latitud { get; set; }
        private double longitud { get; set; }
        private string tipoSede { get; set; }
        private int pertenece { get; set; }
    }
}
