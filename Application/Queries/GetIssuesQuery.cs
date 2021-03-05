using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.EntityFrameworkCore;
using Persistence.Issues;

namespace Application.Queries
{
    public static class GetIssuesQuery
    {

        public record Query() : IRequest<IssueView[]>;

        public class Handler : IRequestHandler<Query, IssueView[]>
        {
            private readonly IIssueViews _repository;

            public Handler(IIssueViews repository)
            {
                _repository = repository;
            }
            public async Task<IssueView[]> Handle(Query request, CancellationToken cancellationToken)
            {
                var res = await _repository.Issues.ToArrayAsync();
                return res;
            }
        }
    }
}