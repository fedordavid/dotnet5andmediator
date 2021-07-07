using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using MediatR;

namespace Application.Commands
{
    public static class CreateIssueCommand
    {
        public record Command(Guid id, IssueInfo info) : IRequest<int>;

        [UsedImplicitly]
        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IIssuesRepository _repository;

            public Handler(IIssuesRepository repository)
            {
                _repository = repository;
            }
            
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                await _repository.Add(new Issue()
                {
                    Id = request.id,
                    Info = request.info
                });
                
                return 1;
            }
        }
    }
}