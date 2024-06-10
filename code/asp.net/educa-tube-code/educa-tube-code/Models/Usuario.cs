using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar E-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [NotMapped] // Não afeta seu banco de dados
        [Compare("Senha")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [NotMapped] // Não afeta seu banco de dados
        [Required(ErrorMessage = "Obrigatório informar Nova Senha!")]
        [DataType(DataType.Password)]
        public string NovaSenha { get; set; }

        [NotMapped] // Não afeta seu banco de dados
        [Required(ErrorMessage = "Obrigatório Confirmar Nova Senha!")]
        [DataType(DataType.Password)]
        public string ConfirmNovaSenha { get; set; }



        public string DataCadastro { get; set; }
        public bool KeepLoggedIn { get; set; }

        public ICollection<Nota> Notas { get; set; }
    }
}
