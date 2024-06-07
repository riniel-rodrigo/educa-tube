using System;
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
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A URL da playlist é obrigatória!")]
        public string Url { get; set; }

        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string ThumbnailUrl { get; set; }

        // Adicionada a propriedade PlaylistId
        public string PlaylistId { get; set; }
    }
}
