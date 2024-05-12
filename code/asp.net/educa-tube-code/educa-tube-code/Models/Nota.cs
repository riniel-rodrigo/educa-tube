using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Notas")]
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título da nota!")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A nota não pode ficar em branco!")]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

    }
}
