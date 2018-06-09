using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Morada = new HashSet<Morada>();
            Prestador = new HashSet<Prestador>();
        }

        public string Cidade1 { get; set; }

        public ICollection<Morada> Morada { get; set; }
        public ICollection<Prestador> Prestador { get; set; }
    }
}
