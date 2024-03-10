using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katalog_3d_api.entities
{
    public class UploadModelDetail
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        public string? Material { get; set; }
        public string? RecommendedUses { get; set; }
        public double? Rating { get; set; }
        public string? SpecialFeature { get; set; }
        public string? Price { get; set; }
        public string? About { get; set; }
        [ForeignKey("UploadModel")]
        public int UploadModelId { get; set; }
        public UploadModel? UploadModel { get; set; }
    }
}