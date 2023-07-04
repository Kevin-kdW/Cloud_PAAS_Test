using System.ComponentModel.DataAnnotations;

namespace PracTest.Models
{
    public class Artists
    {
        [Key]
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }

        //relationship
        public List<Albums> Albums { get; set; }
    }
}
