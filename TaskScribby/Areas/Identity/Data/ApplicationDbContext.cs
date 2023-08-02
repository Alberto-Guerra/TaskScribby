using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TaskScribby.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Project> Projects { get; set; }

        public DbSet<ApplicationUser> applicationUsers { get; set; }    


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ProjectName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ProjectDescription).IsRequired().HasMaxLength(255);
                entity.Property(e => e.ProjectPercentage).IsRequired();
            });

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(x => x.Projects)
                .WithOne(x => x.ApplicationUser); */
        }
    }
}