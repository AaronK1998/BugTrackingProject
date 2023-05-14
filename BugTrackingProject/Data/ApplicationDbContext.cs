using BugTrackingProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.comments)
                .HasForeignKey(c => c.UserId)
                .IsRequired();

            builder.Entity<Comment>()
                .HasOne(c => c.bug)
                .WithMany(u => u.comment)
                .HasForeignKey(c => c.BugId)
                .IsRequired();
        }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<StoryBoard> StoryBoards { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}