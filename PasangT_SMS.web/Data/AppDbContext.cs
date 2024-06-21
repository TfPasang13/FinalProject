using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PasangT_SMS.web.Infrastructure.EntityConfiguration;
using PasangT_SMS.web.Models.Entity;

namespace PasangT_SMS.web.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext)
            : base(dbContext)
        {

        }
        public DbSet<StudentInfo> Students { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<AppUser>()
                .Property(e => e.MiddleName)
                .HasMaxLength(255);

            builder.Entity<AppUser>()
                .Property(e => e.LastName)
                .HasMaxLength(255)
                .IsRequired();

            //builder.Entity<AppUser>()
            //    .Property(e => e.StudentId)
            //    .HasMaxLength(255);

            builder.Entity<AppUser>()
                .Property(e => e.Address)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<AppUser>()
                .Property(e => e.UserRoleId)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<AppUser>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
              

            builder.Entity<AppUser>()
                .Property(e => e.PictureUrl)
                .HasMaxLength(255);

            builder.Entity<AppUser>()
                .Property(e => e.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");
              

            builder.Entity<IdentityRole>()
                .ToTable("Roles")
                .Property(p => p.Id)
                .HasColumnName("RoleId");

            //builder.ApplyConfiguration(new StudentConfiguration());
            //builder.ApplyConfiguration(new CourseConfiguration());
        }
    }
}
