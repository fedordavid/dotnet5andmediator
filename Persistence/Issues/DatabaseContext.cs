using Microsoft.EntityFrameworkCore;
using Persistence.Users;

namespace Persistence.Issues
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<IssueEntity> Issues { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}