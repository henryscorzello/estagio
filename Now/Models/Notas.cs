namespace Now
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Turma { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Aluno { get; set; }

        public int Nota_1 { get; set; }

        public int Nota_2 { get; set; }

        public int Nota_3 { get; set; }

        public int? Nota_4 { get; set; }

        public int? Nota_5 { get; set; }

        public int Media { get; set; }

        [StringLength(50)]
        public string Colocacao { get; set; }

        public virtual Alunos Alunos { get; set; }

        public virtual Turma Turma { get; set; }
    }
}
