using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace educa_tube_code.Models
{
    [Table("Videos")]
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A URL do vídeo é obrigatória!")]
        public string Url { get; set; }

        public string Descricao { get; set; }

        public string Tags { get; set; }

        public DateTime DataCadastro { get; set; }

        public string ThumbnailUrl { get; set; }

        public DateTime DatePublished { get; set; }

        public long ViewCount { get; set; }

        public long LikeCount { get; set; }

        public string ChannelTitle { get; set; }

        public string ChannelThumbnailUrl { get; set; }

        public string Duration { get; set; }

        public string VideoId { get; set; }
    }
}
