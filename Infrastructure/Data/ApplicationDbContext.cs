using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Todos_Infrastructure.EF;

namespace Todos_Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
