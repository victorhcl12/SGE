using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Código das notas")]
        public int id { get; set; }

        [Column("MateriasId")]
        [Display(Name = "codigo das materias")]
        public string MateriasId { get; set; }

        [Column("AlunosId")]
        [Display(Name = "codigo do aluno")]
        public string AlunosId { get; set; } = string.Empty;

        [Column("EtapasId")]
        [Display(Name = "codigo das etapas")]
        public string EtapasId { get;} = string.Empty;

        [Column("Nota")]
        [Display(Name = "Notas")]
        public double Nota { get; set;}
    }
}
