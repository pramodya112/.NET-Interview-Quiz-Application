using Microsoft.EntityFrameworkCore;
using Quize_app.Models;

namespace Quize_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Question> Questions { get; set; }
    }
}
