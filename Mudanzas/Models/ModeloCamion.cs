﻿using System;
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
    public class ModeloCamion
    {
        private CamionDB bd;
        public ModeloCamion()
        {
            bd = new CamionDB();
        }
        // GET CAMION
        public List<Camion> obtenerCamiones()
        {
            return bd.obtenerCamiones();
        }
        // GET CAMION/id
        public Camion obtenerCamion(int id)
        {
            return bd.obtenerCamion(id);
        }
        // POST CAMION
        public Camion RegistrarNuevoCamion(CamionRequest registro)
        { 
            //TODO: modificarle parametros
            Camion nuevoCamion = new Camion(1,registro.kilometraje, registro.kilometrajeUltimoServicio, registro.capacidadPeso, registro.tipoCamion, registro.tipoCombustible, registro.volumen, registro.placas);
            //bd.RegistrarCamion(nuevoCamion);
             bd.RegistrarCamion(nuevoCamion);
            return nuevoCamion;
        }

    }
}
