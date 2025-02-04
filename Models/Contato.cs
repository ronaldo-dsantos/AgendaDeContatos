using System.ComponentModel.DataAnnotations;

namespace AgendaDeContatos.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [StringLength(15, MinimumLength = 14, ErrorMessage = "O campo {0} precisa ter o formato (XX) XXXXX-XXXX")]
        [RegularExpression(@"\(\d{2}\) \d{4,5}-\d{4}", ErrorMessage = "O campo Telefone deve estar no formato (XX) XXXXX-XXXX")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }
    }
}
