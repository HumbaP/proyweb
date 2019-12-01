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

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getAlias()
        {
            return this.alias;
        }

        public void setAlias(string alias)
        {
            this.alias = alias;
        }

        public string getCiudad()
        {
            return this.ciudad;
        }

        public void setCiudad(string ciudad)
        {
            this.ciudad = ciudad;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public double getLatitud()
        {
            return this.latitud;
        }

        public void setLatitud(double latitud)
        {
            this.latitud = latitud;
        }

        public double getLongitud()
        {
            return this.longitud;
        }

        public void setLongitud(double longitud)
        {
            this.longitud = longitud;
        }

        public string getTipoSede()
        {
            return this.tipoSede;
        }

        public void setTipoSede(string tipoSede)
        {
            this.tipoSede = tipoSede;
        }

        public int getPertenece()
        {
            return this.pertenece;
        }

        public void setPertenece(int pertenece)
        {
            this.pertenece = pertenece;
        }
    }
}
