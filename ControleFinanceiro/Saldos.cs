namespace ControleFinanceiro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Saldos
    {
        [Key]
        public int CdSaldo { get; set; }

        [StringLength(50)]
        public string Descr { get; set; }

        public decimal? Vlr { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
