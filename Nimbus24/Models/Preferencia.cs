using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Preferencia
    {
        public string IdPrestador { get; set; }
        public string IdCliente { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public Prestador IdPrestadorNavigation { get; set; }
    }
}
