using BugTrackingProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class StoryboardContext :DbContext
    {
        public virtual DbSet<StoryBoard> StoryBoards { get; set; }
        public virtual DbSet<Bug> Bugs { get; set; }

        public virtual DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=AARON-PC\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            }
        }
    }
}
