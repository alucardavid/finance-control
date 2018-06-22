namespace ControleFinanceiro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FrmsPgmt")]
    public partial class FrmsPgmt
    {
        [Key]
        [Column(Order = 0)]
        public int CdFrmPgmt { get; set; }

        [StringLength(50)]
        public string Descr { get; set; }

        public int? CdSaldo { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public override string ToString()
        {
            return Descr;
        }
    }
}
