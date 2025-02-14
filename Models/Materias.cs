using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Código das materias")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo da materia")]
        public string Titulo { get; set; } = string.Empty;

        [Column("ProfessoresId")]
        [Display(Name = "Código do professor")]
        public string ProfessoresId { get; set; } = string.Empty;
    }

}
