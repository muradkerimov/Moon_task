using Microsoft.EntityFrameworkCore;
using Moon_task.Models;

namespace Moon_task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Jumborton> jumborton { get; set; }
        public DbSet<Counter> counters { get; set; }
        public DbSet<WhoWeAre> whoWeAres { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Portfolio> portfolios { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Pricing> pricing { get; set; }
        public DbSet<Client> clients { get; set; }
    }
}
