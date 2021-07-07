using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Issues
{
    public class IssueCommandRepository : IIssuesRepository
    {
        private DatabaseContext _context { get; }

        public IssueCommandRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Task Add(Issue issue)
        {
            var info = issue.Info;

            _context.Issues.Add(new IssueEntity()
            {
                Id = issue.Id,
                Name = info.Name,
                Description = info.Description
            });

            return _context.SaveChangesAsync();
        }
    }
}