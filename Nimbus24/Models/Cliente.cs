using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Preferencia = new HashSet<Preferencia>();
            Serviço = new HashSet<Serviço>();
        }

        public string Id { get; set; }
        public string Mail { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Contacto { get; set; }

        public ICollection<Preferencia> Preferencia { get; set; }
        public ICollection<Serviço> Serviço { get; set; }
    }
}
