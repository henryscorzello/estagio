namespace Now
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alunos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Aluno { get; set; }

        public int Turma { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public virtual Turmas Turmas { get; set; }
    }
}
