using IPWSLoginService.Models;
using Microsoft.EntityFrameworkCore;


namespace IPWSLoginService.Data
{
    public class AgentPortalUserContext : DbContext
    {
        public AgentPortalUserContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; }
    }
}
