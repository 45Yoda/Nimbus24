using System;
using System.Collections.Generic;

namespace Nimbus24.Models
{
    public partial class Prestador
    {
        public Prestador()
        {
            Preferencia = new HashSet<Preferencia>();
            Serviço = new HashSet<Serviço>();
            TipoServico = new HashSet<TipoServico>();
        }

        public string Id { get; set; }
        public string Nome { get; set; }
        public string Mail { get; set; }
        public int? Rating { get; set; }
        public string Password { get; set; }
        public string Contacto { get; set; }
        public string CidadeCidade { get; set; }

        public Cidade CidadeCidadeNavigation { get; set; }
        public ICollection<Preferencia> Preferencia { get; set; }
        public ICollection<Serviço> Serviço { get; set; }
        public ICollection<TipoServico> TipoServico { get; set; }
    }
}
