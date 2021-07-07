using System.Threading;
using System.Threading.Tasks;
using Application.Pagination;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Issues;

namespace Application.Queries
{
    public static class GetIssuesQuery
    {
        public record Query() : IRequest<IPageable<IssueView>>;

        [UsedImplicitly]
        public class Handler : IRequestHandler<Query, IPageable<IssueView>>
        {
            private readonly IIssueViewsRepository _repository;

            public Handler(IIssueViewsRepository repository)
            {
                _repository = repository;
            }
            public Task<IPageable<IssueView>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Task.FromResult(_repository.Issues.AsPageable());
            }
        }
    }
}