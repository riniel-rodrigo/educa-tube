using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Comentarios")]
    public class Cometario
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public DateTime Data {  get; set; } = DateTime.Now;
        [Display(Name = "Comentário")]
        [Required(ErrorMessage = "Obrigatório escrever um comentário ou cancelar.")]
        [MaxLength(1000, ErrorMessage = "São permitidos no máximo 1000 caracteres.")]
        public string texto { get; set; }

    }
}
