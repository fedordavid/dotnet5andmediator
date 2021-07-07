using System;

namespace Application.Commands
{
    public class Issue
    {
        public Guid Id { get; set; }

        public IssueInfo Info { get; set; }
    }
}