using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mudanzas.Models
{
    public class Autenticacion {
        [Required]
        private string username { get; set; }
        [Required]
        private string password { get; set; }

        public string getUsername()
        {
            return this.username;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
