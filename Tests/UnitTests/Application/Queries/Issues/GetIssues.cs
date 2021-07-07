using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Rewrite;
using Moq;
using Persistence.Issues;
using Xunit;

namespace UnitTests.Application.Queries.Issues
{
    public class GetIssues
    {
        private readonly Mock<IIssueViewsRepository> _issueRepository;

        public GetIssues()
        {
            _issueRepository = new Mock<IIssueViewsRepository>();
        }

        [Fact]
        public async Task Execute_ShouldCallGetIssues()
        {
            //Arrange
            var repository = new Mock<IIssueViewsRepository>();
            var query = new GetIssuesQuery.Query();
            
            var handler = new GetIssuesQuery.Handler(repository.Object);

            ViewCollectionMock<IssueView> issues = new ViewCollectionMock<IssueView>(new List<IssueView>
            {
                new IssueViewBuilder().Build()
            });
            
            repository.Setup(x => x.Issues).Returns(issues);
            
            //Act
            var result = await handler.Handle(query, CancellationToken.None);
            
            //Assert
            Assert.Equal(issues, result);
        }
    }
}