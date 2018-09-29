namespace AcademyWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("academy.Matricula")]
    public partial class Matricula
    {
        [Key]
        [Column(Order = 0)]
        public int idMatricula { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Data { get; set; }
    }
}
