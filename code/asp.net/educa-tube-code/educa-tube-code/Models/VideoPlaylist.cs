using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace educa_tube_code.Models
{

    [Table("VideoPlaylist")]
    public class VideoPlaylist
    {
        [Key]
        public int Id { get; set; }

        public int VideoId { get; set; }

        [Display(Name = "Video")]
        [ForeignKey("VideoId")]
        public Video Video { get; set; }

        public int PlaylistId { get; set; }

        [Display(Name = "Playlist")]
        [ForeignKey("PlaylistId")]
        public Playlist playlist { get; set; }
    }
}
