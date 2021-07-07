using System;
using System.Threading.Tasks;
using Persistence.Issues;

namespace Application.Commands
{
    public interface IIssuesRepository
    {
        Task Add(Issue issue);
    }
}