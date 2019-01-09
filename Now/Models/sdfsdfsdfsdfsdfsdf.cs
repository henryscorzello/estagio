namespace Now
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class sdfsdfsdfsdfsdfsdf : DbContext
    {
        public sdfsdfsdfsdfsdfsdf()
            : base("name=sdfsdfsdfsdfsdfsdf")
        {
        }

        public virtual DbSet<Alunos> Alunos { get; set; }
        public virtual DbSet<Notas> Notas { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Turma> Turma { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Alunos>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Alunos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notas>()
                .Property(e => e.Colocacao)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Status1)
                .IsUnicode(false);

            modelBuilder.Entity<Turma>()
                .Property(e => e.Turma1)
                .IsUnicode(false);

            modelBuilder.Entity<Turma>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Turma)
                .WillCascadeOnDelete(false);
        }
    }
}
