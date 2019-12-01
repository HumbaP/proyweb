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

    }
}
