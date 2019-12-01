using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mudanzas.Models
{
    public class Google
    {
     
        private string destination_addresses { get; set; }
        private string origin_addresses { get; set; }
        private string rows { get; set; }

        public string getDestinationAddresses()
        {
            return this.destination_addresses;
        }

        public void setDestinationAddresses(string destination_addresses)
        {
            this.destination_addresses = destination_addresses;
        }

        public string getOriginAddresses()
        {
            return this.origin_addresses;
        }

        public void setOriginAddresses(string origin_addresses)
        {
            this.origin_addresses = origin_addresses;
        }

        public string getRows()
        {
            return this.rows;
        }
        public void setRows(string rows)
        {
            this.rows = rows;
        }

    }
}
