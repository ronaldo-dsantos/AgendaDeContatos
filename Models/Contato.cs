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

        [Phone(ErrorMessage = "Telefone inválido")]
        [Required(ErrorMessage = "O campo telefone é obrigatório")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }
    }
}
