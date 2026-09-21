using Microsoft.EntityFrameworkCore;
using STAR_PRC_SEA.Models;
using STAR_PRC_SEA.Models.Users;

namespace STAR_PRC_SEA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}