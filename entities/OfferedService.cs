using System.ComponentModel.DataAnnotations;

namespace katalog_3d_api.entities
{
    public class OfferedService
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

    }
}