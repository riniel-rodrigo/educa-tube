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
        public string Senha { get; set; }
        public string DataCadastro { get; set; }
        public bool KeepLoggedIn { get; set; }

        public List<Nota> Notas { get; set; }
    }
}
