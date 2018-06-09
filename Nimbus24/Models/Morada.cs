using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Morada
    {
        public Morada()
        {
            Serviço = new HashSet<Serviço>();
        }

        public int Id { get; set; }
        public string Rua { get; set; }
        public int? Porta { get; set; }
        public string CodPostal { get; set; }
        public string CidadeCidade { get; set; }

        public Cidade CidadeCidadeNavigation { get; set; }
        public ICollection<Serviço> Serviço { get; set; }
    }
}
