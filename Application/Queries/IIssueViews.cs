using System.Linq;

namespace Persistence.Issues
{
    public interface IIssueViews
    {
        public IQueryable<IssueView> Issues { get; }
    }
}