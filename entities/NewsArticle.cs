using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katalog_3d_api.entities
{
    public class NewsArticle
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string? Title { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Publisher { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Category { get; set; }

        [Url]
        public string? ImgUrl { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public string? Summary { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string? Content { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string? MetaScript { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? Keyword { get; set; }

        [ForeignKey("User")]
        public int AuthorId { get; set; }
        public User? User { get; set; }
    }

}