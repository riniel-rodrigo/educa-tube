using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Pomodoros")]
    public class Pomodoro
    {
        [Key]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int Tempo { get; set; } = 20;
        public int Quantidade { get; set; } = 1;
        public bool Bloqueia { get; set; } = false;

    }
}
