using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracTest.Models
{
    public class Albums
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(1950,2020)]
        public int Year { get; set; }


        //relationship
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artists Artists { get; set; }
    }
}
