using System;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Issues
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<IssueEntity> Issues { get; set; }
    }
}