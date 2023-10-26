using EV.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.ContentModel;
using System.Collections.Generic;

namespace EV.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Ivent> Ivent { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
