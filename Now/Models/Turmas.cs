namespace Now
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Turmas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turmas()
        {
            Alunos = new HashSet<Alunos>();
        }

        [Key]
        public int Id_Turmas { get; set; }

        [Column("Turmas")]
        [Required]
        [StringLength(50)]
        public string Turmas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alunos> Alunos { get; set; }
    }
}
