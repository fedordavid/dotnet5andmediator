using System.Linq;

namespace Persistence.Issues
{
    public interface IIssueViewsRepository
    {
        public IQueryable<IssueView> Issues { get; }
    }
}