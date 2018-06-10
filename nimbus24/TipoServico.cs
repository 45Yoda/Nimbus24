namespace Nimbus24
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoServico")]
    public partial class TipoServico
    {
        [StringLength(50)]
        public string id { get; set; }

        public int? tipo { get; set; }

        public decimal? preco { get; set; }

        [StringLength(50)]
        public string id_Prestador { get; set; }

        public int? negociavel { get; set; }

        public virtual Prestador Prestador { get; set; }
    }
}
