namespace ControleFinanceiro
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ControleFinanceiroContext : DbContext
    {
        public ControleFinanceiroContext()
            : base("name=ControleFinanceiroContext")
        {
        }

        public virtual DbSet<DespesaMensal> DespesaMensal { get; set; }
        public virtual DbSet<DespesaVariavel> DespesaVariavel { get; set; }
        public virtual DbSet<Saldos> Saldos { get; set; }
        public virtual DbSet<FrmsPgmt> FrmsPgmt { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DespesaMensal>()
                .Property(e => e.Local)
                .IsUnicode(false);

            modelBuilder.Entity<DespesaMensal>()
                .Property(e => e.Descr)
                .IsUnicode(false);

            modelBuilder.Entity<DespesaMensal>()
                .Property(e => e.StatusPgmt)
                .IsUnicode(false);

            modelBuilder.Entity<DespesaVariavel>()
                .Property(e => e.Local)
                .IsUnicode(false);

            modelBuilder.Entity<DespesaVariavel>()
                .Property(e => e.Descr)
                .IsUnicode(false);

            modelBuilder.Entity<DespesaVariavel>()
                .Property(e => e.TipGasto)
                .IsUnicode(false);

            modelBuilder.Entity<Saldos>()
                .Property(e => e.Descr)
                .IsUnicode(false);

            modelBuilder.Entity<FrmsPgmt>()
                .Property(e => e.Descr)
                .IsUnicode(false);
        }
    }
}
