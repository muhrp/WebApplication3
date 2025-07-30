using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext(DbContextOptions<RepositoryContext> options, IHttpContextAccessor httpContextAccessor) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Honor> Honor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Honor>(entity =>
            {
                entity.ToTable("RefHonors");
            });
        }
    }
}
