using Microsoft.EntityFrameworkCore;
using TeamManagerBackend.Models;

namespace TeamManagerBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}
