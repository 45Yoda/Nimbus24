using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class TipoServico
    {
        public string Id { get; set; }
        public int? Tipo { get; set; }
        public decimal? Preco { get; set; }
        public string IdPrestador { get; set; }
        public int? Negociavel { get; set; }

        public Prestador IdPrestadorNavigation { get; set; }
    }
}
