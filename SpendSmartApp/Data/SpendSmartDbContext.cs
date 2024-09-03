using Microsoft.EntityFrameworkCore;
using SpendSmartApp.Models;

namespace SpendSmartApp.Data
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options)
        {
            
        }
    }
}
