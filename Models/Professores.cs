using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("Id")]
        [Display(Name = "Código do professor")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do professor")]
        public string Nome { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do professor")]
        public string Email { get; set;} = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do professor")]
        public string Telefone { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Cpf do professor")]
        public string Cpf { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de nascimento do professor")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}
