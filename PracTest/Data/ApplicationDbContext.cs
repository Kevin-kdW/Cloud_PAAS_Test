using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracTest.Models;

namespace PracTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PracTest.Models.Songs> Songs { get; set; }
        public DbSet<PracTest.Models.Genre> Genre { get; set; }
        public DbSet<PracTest.Models.Artists> Artists { get; set; }
        public DbSet<PracTest.Models.Albums> Albums { get; set; }
    }
}