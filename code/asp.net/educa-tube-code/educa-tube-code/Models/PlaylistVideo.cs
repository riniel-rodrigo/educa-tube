using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("PlaylistVideo")]
    public class PlaylistVideo
    {
        [Key]
        public int Id { get; set; }

        public int VideoId { get; set; }

        [Display(Name = "Video")]
        [ForeignKey("VideoId")]
        public Video Video { get; set; }

        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

    }
}
