using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katalog_3d_api.entities
{
    public class UploadModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("User")]
        public int OwnerId { get; set; }
        public User? User { get; set; }
    }
}