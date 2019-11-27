﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Models.Auth
{
    public class Cliente: Usuario
    {
        private string direccion;
        private string ciudad;
        public override string getRole()
        {
            return Rol.Cliente;
        }


        public Cliente()
        {

        }
        public Cliente(int id, string nombre, string primerApellido, string segundoApellido, string telefono, string correoElectronico, string password, string direccion, string ciudad)
        {
            this.setId(id);
            this.setNombre(nombre);
            this.setPrimerApellido(primerApellido);
            this.setSegundoApellido(segundoApellido);
            this.setTelefono(telefono);
            this.setCorreoElectronico(correoElectronico);
            this.setDireccion(direccion);
            this.setCiudad(ciudad);
            this.setPassword(password);
        }

        public Cliente( string nombre, string primerApellido, string segundoApellido, string telefono, string correoElectronico,string password ,string direccion, string ciudad)
        {
            this.setNombre(nombre);
            this.setPrimerApellido(primerApellido);
            this.setSegundoApellido(segundoApellido);
            this.setTelefono(telefono);
            this.setCorreoElectronico(correoElectronico);
            this.setDireccion(direccion);
            this.setCiudad(ciudad);
            this.setPassword(password);
        }
        public Cliente(string nombre, string primerApellido, string segundoApellido, string telefono, string correoElectronico, string direccion)
        {
            this.setNombre(nombre);
            this.setPrimerApellido(primerApellido);
            this.setSegundoApellido(segundoApellido);
            this.setTelefono(telefono);
            this.setCorreoElectronico(correoElectronico);
            this.setDireccion(direccion);
        }
         public Cliente(string nombre, string primerApellido, string segundoApellido, string telefono, string correoElectronico, string direccion, string token)
        {
            this.setNombre(nombre);
            this.setPrimerApellido(primerApellido);
            this.setSegundoApellido(segundoApellido);
            this.setTelefono(telefono);
            this.setCorreoElectronico(correoElectronico);
            this.setDireccion(direccion);
            this.setToken(token);
        }

        public string getDireccion()
        {
            return this.direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getCiudad()
        {
            return this.ciudad;
        }
        public void setCiudad(string ciudad)
        {
            this.ciudad= ciudad;
        }
    }
}
