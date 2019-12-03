using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mudanzas.Models.Auth;
using Mudanzas.Models;
using Mudanzas.Helpers.Requests;
using Mudanzas.Services.IServices;
using Mudanzas.Data;
using Mudanzas.Helpers;

namespace Mudanzas.Models
{
    public class ModeloReservacion
    {
        private ReservacionDB bd;
        public ModeloReservacion()
        {
            bd = new ReservacionDB();
        }
        

        
        public void postExceso(int folioReservacion)
        {
            bd.postExceso(folioReservacion);
        }

        public List<Reservacion> obtenerReservaciones()
        {
            List<Reservacion> reservaciones = bd.GetReservaciones();
            
            return reservaciones;
        }

        public double especificaReservacion(ReservacionRequest informacion)
        {
            double precio = 1;
            string disponible = bd.buscaDisponibilidad(informacion.fechaReservacion, informacion.sedeOrigen, informacion.tipoCamion );
            if(disponible != "NULL" )
            {
                //precio = bd.getCosto(informacion.sedeOrigen,informacion.sedeDestino);
                precio = bd.getCosto(1,2);

            }
            return precio;
        }
    }
}
