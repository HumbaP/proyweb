﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mudanzas.Models.Auth;
using Mudanzas.Helpers.Requests;
using Mudanzas.Services.IServices;
using Mudanzas.Data;
using Mudanzas.Helpers;
<<<<<<< HEAD
using Mudanzas.Models;
=======
using Mudanzas.Helpers.Templates;
>>>>>>> Agregado template de correos

namespace Mudanzas.Models
{
    public class UsuarioModel
    {

        private readonly IUsuarioDB db;

        public UsuarioModel()
        {
            db = new UsuarioDB();
        }
        //TODO: Agregar encriptado a las contrasenas
        public Usuario AutenticarChofer(LoginRequest usuarioLogin)
        {
            Chofer chofer = db.AutorizarChofer(usuarioLogin.correoElectronico, usuarioLogin.password);
            if (chofer != null)
            {
                chofer.setToken(JWTHelper.convertoUsuarioToJWT(chofer));
                return chofer;

            }
            return null;
        }

        public Chofer RegistrarChofer(RegistroChoferRequest choferRequest)
        {
            //TODO: Checar esto
            Chofer chofer = new Chofer();
            db.RegistrarChofer(chofer);
            return null;
        }

        public Usuario AutenticarCliente(LoginRequest usuarioLogin)
        {
            Cliente cliente= db.AutorizarCliente(usuarioLogin.correoElectronico, usuarioLogin.password);
            if (cliente != null)
            {
                cliente.setToken(JWTHelper.convertoUsuarioToJWT(cliente));
                return cliente;
            }
            return null;
        }

        public Usuario AutenticarAdmin(LoginRequest usuarioLogin)
        {
            Administrador admin= db.AutorizarAdministrador(usuarioLogin.correoElectronico, usuarioLogin.password);
            if(admin!=null){
                admin.setToken(JWTHelper.convertoUsuarioToJWT(admin));
                return admin;
            }
            return null;
        }

        public Cliente RegistrarCliente(int idProspecto)
        {
            Cliente c = db.MoverProspectoACliente(idProspecto);
            return c;
        }
        public Cliente RegistrarNuevoCliente(RegistroRequest registro)
        {
            //TODO: modificarle parametros
            Cliente nuevoCliente= new Cliente(registro.nombre, registro.primerApellido, registro.segundoApellido, registro.telefono, registro.correoElectronico, registro.direccion, $"{new Random().Next(10000000, 99999999)}");
            db.RegistrarProspecto(nuevoCliente);
            string email =  UsuarioEmailTemplate.bienvenidoProspecto($"{nuevoCliente.getNombre()} {nuevoCliente.getPrimerApellido()}", nuevoCliente.getToken(), "http://www.proyweb.com.mx");
            EmailHelper.sendEmail(nuevoCliente.getCorreoElectronico(), $"{nuevoCliente.getNombre()} {nuevoCliente.getPrimerApellido()}", email);
            // EmailHelper.sendSMSCodigoVerificacion(nuevoCliente.getTelefono(), nuevoCliente.getToken());
            return nuevoCliente;
        }
        public Cliente VerificarProspecto(string codigoVerificacion)
        {
            //TODO: Modificar esto para que regrese algo el cliente
            Cliente prospecto = new Cliente();
            prospecto.setToken(codigoVerificacion);
            db.VerificacionProspecto(prospecto);
            return prospecto;
        }
    }
}
