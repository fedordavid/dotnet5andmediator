using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Issues
{
    public class IssueQueryRepository : IIssueViewsRepository
    {
        private DatabaseContext _context { get; }
        private IMapper _mapper { get; }

        public IssueQueryRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IQueryable<IssueView> Issues =>
            _context.Issues.AsNoTracking().ProjectTo<IssueView>(_mapper.ConfigurationProvider);
    }
}