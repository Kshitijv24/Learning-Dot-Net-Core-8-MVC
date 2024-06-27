using FirstProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<CategoryModel> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { Id = 1, Name = "Action", DisplayOrder = 1 },
                new CategoryModel { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new CategoryModel { Id = 3, Name = "Comedy", DisplayOrder = 3 });
        }
    }
}
