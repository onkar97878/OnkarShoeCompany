using Microsoft.EntityFrameworkCore;
using OnkarShoeCompany.Models;

namespace OnkarShoeCompany.Data
{
    public class OnkarShoeContext : DbContext
    {
        public OnkarShoeContext(DbContextOptions<OnkarShoeContext> options)
            : base(options)
        {
        }

        public DbSet<Shoe> Shoe { get; set; }
    }
}