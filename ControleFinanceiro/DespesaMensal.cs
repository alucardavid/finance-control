namespace ControleFinanceiro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DespesaMensal")]
    public partial class DespesaMensal
    {
        [Key]
        public int Cod { get; set; }

        [StringLength(50)]
        public string Local { get; set; }

        [StringLength(50)]
        public string Descr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data { get; set; }

        public int CdFrmPgmt { get; set; }

        public decimal? Vlr { get; set; }

        public int? QtdParcelas { get; set; }

        public int? ParcelaAtual { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DtVenc { get; set; }

        [StringLength(50)]
        public string StatusPgmt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
