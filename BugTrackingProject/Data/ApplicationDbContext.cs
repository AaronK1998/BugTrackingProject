﻿using BugTrackingProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public  DbSet<AspNetRole> AspNetRoles { get; set; }

        public  DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        public  DbSet<AspNetUser> AspNetUsers { get; set; }

        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        public DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

        public DbSet<Bug> Bugs { get; set; }

        public DbSet<BugDescription> BugDescriptions { get; set; }

        public DbSet<StoryBoard> StoryBoards { get; set; }
    }
}