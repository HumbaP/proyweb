using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mudanzas.Helpers.Requests;
using Mudanzas.Models;

namespace Mudanzas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        ModeloReservacion modelo;
        public ReservacionController()
        {
            modelo = new ModeloReservacion();
        }
        // POST: api/Reservacion
         [HttpPost("exceso")]
         public ExcesoRequest postExceso([FromBody]ExcesoRequest excesoRequest)
         {
            modelo.postExceso(excesoRequest.folio);
            return excesoRequest;
         }

        
        
        
         [HttpPost("disponible")]
         public double especificaReservacion([FromBody] ReservacionRequest informacionReserva)
         {
            return modelo.especificaReservacion(informacionReserva);
         }

         // POST Crear la reservacion
         [HttpPost]
         public ReservacionRequest ingresarDatosReservacion([FromBody] ReservacionRequest informacionReserva)
         {
            modelo.ingresarReserva(informacionReserva);
            return informacionReserva;
         }

/*
        [HttpPost("pago")]
         public PagoRequest ingresarDatosPago([FromBody] PagoRequest informacionPago)
         {
            modelo.pagaReservacion(informacionPago);
            return informacionPago;
         }
*/



    }
}