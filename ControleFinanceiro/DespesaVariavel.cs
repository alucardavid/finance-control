namespace ControleFinanceiro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DespesaVariavel")]
    public partial class DespesaVariavel
    {
        [Key]
        public int Cod { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        [StringLength(100)]
        public string Local { get; set; }

        [StringLength(100)]
        public string Descr { get; set; }

        public int? CdFrmPgmt { get; set; }

        [StringLength(50)]
        public string TipGasto { get; set; }

        public decimal? Vlr { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
