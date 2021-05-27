using Microsoft.EntityFrameworkCore;

namespace Graduation.Core
{
    public class PostalCodeContext : DbContext
    {
        public PostalCodeContext(DbContextOptions<PostalCodeContext> options) : base(options)
        {

        }

        public DbSet<PostalCode> PostalCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PostalCode>()
                .ToTable("geo_PostalCodes")
                .HasKey(x => x.Code);
        }
    }
}