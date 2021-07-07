using System;
using System.Threading.Tasks;
using Application.Commands;
using Application.Queries;
using MediatR;
using Moq;
using Persistence.Issues;
using Xunit;

namespace UnitTests.Application.Queries.Issues
{
    public class GetIssueById
    {
        private Mock<IIssueViewsRepository> _mockRepository;
        
        public GetIssueById()
        {
            _mockRepository = new Mock<IIssueViewsRepository>();
        }

        [Fact]
        // public async Task<IssueView> GetIssueById()
        // {
        //     //Arrange
        //     var queryHandler = new GetIssueByIdQuery.Handler(_mockRepository.Object);
        //     //Act
        //
        //     //Assert
        // }
    }
}