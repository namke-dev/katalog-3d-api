using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace katalog_3d_api.entities
{
    public class NewsArticle
    {
        [Key]
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Date { get; set; }
        public string? Publisher { get; set; }
        public string? Category { get; set; }
        public string? ImgUrl { get; set; }
        public string? Summary { get; set; }
        public string? Content { get; set; }

        [ForeignKey("User")]
        public int AuthorId { get; set; }
        public User? User { get; set; }
    }

}