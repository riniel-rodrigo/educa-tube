using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Playlists")]
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título da playlist é obrigatório!")]
        [DisplayName("Nome Playlist")]
        public string Titulo { get; set; }

        public string Url { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ThumbnailUrl { get; set; }
        public int UsuarioId { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

    }
}
