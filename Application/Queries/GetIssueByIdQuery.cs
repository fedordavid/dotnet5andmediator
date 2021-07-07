using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Issues;

namespace Application.Queries
{
    public static class GetIssueByIdQuery
    {
        public record Query(Guid id) : IRequest<IssueView>;
        
        public class Handler : IRequestHandler<Query, IssueView>
        {
            private readonly IIssueViewsRepository _repository;

            public Handler(IIssueViewsRepository repository)
            {
                _repository = repository;
            }
            
            public async Task<IssueView> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _repository.Issues.FirstOrDefaultAsync(i => i.Id == request.id, cancellationToken: cancellationToken);
            }
        }
    }
}