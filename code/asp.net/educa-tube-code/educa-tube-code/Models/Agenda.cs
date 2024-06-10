using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Agendas")]
    public class Agenda
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        [Display(Name = "nome do evento")]
        [Required(ErrorMessage = "Obrigatório informar um nome para o evento.")]
        [MaxLength(100, ErrorMessage = "São permitidos no máximo 100 caracteres.")]
        public string Evento { get; set; } = "Nome do evento";
        public DateTime Data {  get; set; }

    }
}
