namespace AcademyWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("academy.Curso")]
    public partial class Curso
    {
        [Key]
        public int idcurso { get; set; }

        public string descricao { get; set; }

        public string ano_mes { get; set; }

        public int? Avaliacao_idAvaliacao { get; set; }

        public int? Matricula_idMatricula { get; set; }
    }
}
