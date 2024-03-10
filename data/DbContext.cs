
using katalog_3d_api.entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


namespace katalog_3d_api.data
{
    public class KatalogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<NewsArticle> NewsArticles { get; set; }
        public DbSet<OfferedService> OfferedServices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<UploadModel> UploadModels { get; set; }
        public DbSet<UploadModelDetail> UploadModelDetails { get; set; }

        public KatalogContext()
        {
        }
        protected KatalogContext(DbContextOptions<KatalogContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=katalogdb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}