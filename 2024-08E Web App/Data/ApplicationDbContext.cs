using _2024_08E_Web_App.Models;

using Microsoft.EntityFrameworkCore;

namespace _2024_08E_Web_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Vouchar> Vouchers { get; set; }

    }
}