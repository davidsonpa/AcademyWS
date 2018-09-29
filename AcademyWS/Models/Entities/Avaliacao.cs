namespace AcademyWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("academy.Avaliacao")]
    public partial class Avaliacao
    {
        [Key]
        [Column(Order = 0)]
        public int idAvaliacao { get; set; }

        public string descricao { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime data { get; set; }

        public int? Nota_idNota { get; set; }
    }
}
