using Mudanzas.Models.Auth;
using Mudanzas.Services.IServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Mudanzas.Models;
using Mudanzas.Helpers.Requests;

namespace Mudanzas.Data
{
    public class ReservacionDB
    {
        public readonly SqlConnection db = ConexionDB.GetConnection();

       

        // POST/ID reservacion
        public void postExceso(int folio)
        {

            //string query = $"SP_ALTACAMIONES {folio}";
            string query = $"EXEC REGISTROEXCESO @Folio = {folio}";
            using (SqlCommand com = new SqlCommand(query, db))
            {
                com.ExecuteNonQuery();
                db.Close();
            }
        }

         // POST/ID reservacion
       public string buscaDisponibilidad(string fecha, string sedeOrigen, string tipoCamion)
        {
     
             return "GDE0001";
        }
        // GET COSTO
        public double getCosto(int idSedeOrigen, int idSedeDestino)
        {
            //distancia = sp
            double distancia = 32.20;
            // Calcular el costo
            decimal costo = 0;
            using (SqlCommand com = new SqlCommand($"SELECT c.costo  FROM Costos c where CONCEPTO = 'Exceso' ", db))
            {
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        costo = reader.GetDecimal(0);
                    }
                }
                reader.Close();
            }
            // Operacion Costo
         
            return distancia * ((double) costo);
        }
        public void guardarReservacion(ReservacionRequest reservacion)
        {
              
            string query = $"registraReserva '{reservacion.sedeOrigen}','{reservacion.sedeDestino}','04/12/2019', '{reservacion.tipoCamion}','{reservacion.idCliente}'";
            using (SqlCommand com = new SqlCommand(query, db))
            {
                com.ExecuteNonQuery();
                db.Close();
            }
        
        // Ya que se ejecuta el sp y listo

        }

       // public void realizaCargo(Pago pago)
        //{
            /* 
            string query = $"SP_ALTAPAGOS '{pago.folio}',{pago.monto}, {pago.terminacionTarjeta}, '{pago.estatus}',{pago.fecha}'";
            using (SqlCommand com = new SqlCommand(query, db))
            {
                com.ExecuteNonQuery();
                db.Close();
            }
        */
        // Ya que se ejecuta el sp y listo


        //}


    }
}
