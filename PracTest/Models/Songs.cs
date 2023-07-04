using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracTest.Models
{
    public class Songs
    {
        [Key]
        public int SongId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Preview { get; set; }


        //relationship
        public int AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public Albums Albums { get; set; }

    }
}
