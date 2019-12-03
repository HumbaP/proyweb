using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Models
{
    public class Camion
    {
        public Camion(string id, decimal kilometraje, decimal kilometrajeUltimoServicio, decimal capacidadPeso, string tipoCamion,string tipoCombustible, decimal volumen, string placas)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.kilometrajeUltimoServicio = kilometrajeUltimoServicio;
            this.capacidadPeso = capacidadPeso;
            this.tipoCamion = tipoCamion;
            this.tipoCombustible = tipoCombustible;
            this.volumen = volumen;
            this.placas = placas;
        }
        private string id { get; set; }
        private decimal kilometraje { get; set; }
        private decimal kilometrajeUltimoServicio { get; set; }
        private decimal capacidadPeso { get; set; }
        private string tipoCamion { get; set; }
        private string tipoCombustible { get; set; }
        private decimal volumen { get; set; }
        private string placas { get; set; }

        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public decimal getKilometraje()
        {
            return this.kilometraje;
        }

        public void setKilometraje(decimal kilometraje)
        {
            this.kilometraje = kilometraje;
        }

        public decimal getKilometrajeUltimoServicio()
        {
            return this.kilometrajeUltimoServicio;
        }

        public void setKilometrajeUltimoServicio(decimal kilometrajeUltimoServicio)
        {
            this.kilometrajeUltimoServicio = kilometrajeUltimoServicio;
        }

        public decimal getCapacidadPeso()
        {
            return this.capacidadPeso;
        }

        public void setCapacidadPeso(decimal capacidadPeso)
        {
            this.capacidadPeso = capacidadPeso;
        }

        public string getTipoCamion()
        {
            return this.tipoCamion;
        }

        public void setTipoCamion(string tipoCamion)
        {
            this.tipoCamion = tipoCamion;
        }

        public string getTipoCombustible()
        {
            return this.tipoCombustible;
        }

        public void setTipoCombustible(string tipoCombustible)
        {
            this.tipoCombustible = tipoCombustible;
        }

        public decimal getVolumen()
        {
            return this.volumen;
        }

        public void setVolumen(decimal volumen)
        {
            this.volumen = volumen;
        }

        public string getPlacas()
        {
            return this.placas;
        }

        public void setPlacas(string placas)
        {
            this.placas = placas;
        }

    }
}
