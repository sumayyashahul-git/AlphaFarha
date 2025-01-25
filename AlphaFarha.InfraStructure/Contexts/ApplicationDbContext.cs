using AlphaFarha.Core.Models;
using AlphaFarha.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AlphaFarha.InfraStructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<MRF> MRFs { get; set; }
        public DbSet<MRFItem> MRFItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Project>().HasData(
                  new Project { Id = Guid.NewGuid(), Name = "Project 1", Code = "PJ0001" },
                  new Project { Id = Guid.NewGuid(), Name = "Project 2", Code = "PJ0002" },
                  new Project { Id = Guid.NewGuid(), Name = "Project 3", Code = "PJ0003" }
              );
        }

    }
}
