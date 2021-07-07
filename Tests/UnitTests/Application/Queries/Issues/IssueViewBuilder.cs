using System;
using Persistence.Issues;

namespace UnitTests.Application.Queries.Issues
{
    public class IssueViewBuilder
    {
        private string _name = "Issue with elevator";
        private string _description = "Broken Window";
        private string _userName = "David Fedor";
        private Guid _id = new();

        public IssueView Build()
        {
            return new()
            {
                Id = _id,
                Name = _name,
                UserName = _userName,
                Description = _description
            };
        }
    }
}