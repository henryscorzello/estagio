namespace Now
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Alunos> Alunos { get; set; }
        public virtual DbSet<Turmas> Turmas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Turmas>()
                .Property(e => e.Turmas1)
                .IsUnicode(false);

            modelBuilder.Entity<Turmas>()
                .HasMany(e => e.Alunos)
                .WithRequired(e => e.Turmas)
                .HasForeignKey(e => e.Turma)
                .WillCascadeOnDelete(false);
        }
    }
}
