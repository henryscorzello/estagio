namespace Now
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [Key]
        public int Id_Status { get; set; }

        [Column("Status")]
        [Required]
        [StringLength(50)]
        public string Status1 { get; set; }
    }
}
