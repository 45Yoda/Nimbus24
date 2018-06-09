using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Serviço
    {
        public Serviço()
        {
            Avaliação = new HashSet<Avaliação>();
        }

        public string Id { get; set; }
        public decimal? Preço { get; set; }
        public DateTime? Data { get; set; }
        public int? Estado { get; set; }
        public string IdCliente { get; set; }
        public string IdPrestador { get; set; }
        public string Descrição { get; set; }
        public int? MoradaId { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public Prestador IdPrestadorNavigation { get; set; }
        public Morada Morada { get; set; }
        public ICollection<Avaliação> Avaliação { get; set; }
    }
}
