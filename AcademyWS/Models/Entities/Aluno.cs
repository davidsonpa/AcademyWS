namespace AcademyWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("academy.Aluno")]
    public partial class Aluno
    {
        [Required]
        [StringLength(11)]
        public string cpf { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAluno { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }

        [StringLength(50)]
        public string municipio { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        [Key]
        [StringLength(100)]
        public string email { get; set; }

        public int? Matricula_idMatricula { get; set; }

        public int? Nota_idNota { get; set; }

        [StringLength(30)]
        public string senha { get; set; }
    }
}
