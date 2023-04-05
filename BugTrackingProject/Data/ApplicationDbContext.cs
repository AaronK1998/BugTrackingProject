using BugTrackingProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Bug> Bugs { get; set; }

        public DbSet<BugDescription> BugDescriptions { get; set; }

        public DbSet<StoryBoard> StoryBoards { get; set; }
    }
}