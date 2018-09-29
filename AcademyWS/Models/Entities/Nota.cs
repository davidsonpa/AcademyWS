namespace AcademyWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("academy.Nota")]
    public partial class Nota
    {
        [Key]
        [Column(Order = 0)]
        public int idNota { get; set; }

        [Key]
        [Column("nota", Order = 1)]
        public decimal nota1 { get; set; }
    }
}
