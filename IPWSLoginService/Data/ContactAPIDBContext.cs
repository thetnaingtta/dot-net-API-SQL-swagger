using IPWSLoginService.Models;
using Microsoft.EntityFrameworkCore;

namespace IPWSLoginService.Data
{
    public class ContactAPIDBContext : DbContext
    {
        public ContactAPIDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
