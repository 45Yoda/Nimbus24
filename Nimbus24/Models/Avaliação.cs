using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Avaliação
    {
        public string Id { get; set; }
        public int? Avaliacao { get; set; }
        public string Obs { get; set; }
        public string ServicoId { get; set; }

        public Serviço Servico { get; set; }
    }
}
