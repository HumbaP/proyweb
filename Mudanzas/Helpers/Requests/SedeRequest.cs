using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mudanzas.Models;

namespace Mudanzas.Helpers.Requests
{
    public class SedeRequest
    {

        public SedeRequest()
        {

        }

        public SedeRequest(Sede sede)
        {
            this.id = sede.getId();
            this.alias = sede.getAlias();
            this.ciudad = sede.getCiudad();
            this.estado = sede.getEstado();
            this.latitud = sede.getLatitud();
            this.longitud = sede.getLongitud();
            this.tipoSede = sede.getTipoSede();
            this.pertenece = sede.getPertenece();
        }

        public int id { get; set; }
        public string alias { get; set; }
        public string ciudad { get; set; }
        public string estado { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public string tipoSede { get; set; }
        public int pertenece { get; set; }
    }
}




