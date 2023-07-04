using System.ComponentModel.DataAnnotations;

namespace PracTest.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }

        //relationship
        public List<Albums> Albums { get; set; }
    }
}
