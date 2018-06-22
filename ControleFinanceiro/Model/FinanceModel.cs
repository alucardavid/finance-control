namespace ControleFinanceiro.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FinanceModel : DbContext
    {
        public FinanceModel()
            : base("name=FinanceModel")
        {
        }

        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategorys { get; set; }
        public virtual DbSet<FormOfPayment> FormOfPayments { get; set; }
        public virtual DbSet<MonthlyExpense> MonthlyExpenses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VariableExpense> VariableExpenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>()
                .HasMany(e => e.FormOfPayment)
                .WithOptional(e => e.Balance)
                .HasForeignKey(e => e.Balance_Id);

            modelBuilder.Entity<ExpenseCategory>()
                .HasMany(e => e.MonthlyExpense)
                .WithOptional(e => e.ExpenseCategory)
                .HasForeignKey(e => e.ExpenseCategory_Id);

            modelBuilder.Entity<FormOfPayment>()
                .HasMany(e => e.MonthlyExpense)
                .WithOptional(e => e.FormOfPayment)
                .HasForeignKey(e => e.FormOfPayment_Id);

            modelBuilder.Entity<FormOfPayment>()
                .HasMany(e => e.VariableExpense)
                .WithOptional(e => e.FormOfPayment)
                .HasForeignKey(e => e.FormOfPayment_Id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Balance)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_CPF);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MonthlyExpense)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_CPF);

            modelBuilder.Entity<User>()
                .HasMany(e => e.VariableExpense)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.User_CPF);
        }
    }
}
