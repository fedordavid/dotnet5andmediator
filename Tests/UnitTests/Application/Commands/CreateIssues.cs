using System;
using System.Threading;
using Application.Commands;
using Moq;
using Xunit;

namespace UnitTests.Application.Commands
{
    public class CreateIssues
    {

        private Mock<IIssuesRepository> _repository;
        
        public CreateIssues()
        {
            _repository = new Mock<IIssuesRepository>();
        }

        [Fact]
        public void Should_CallCreateIssues()
        {
            //Arrange
            var id = new Guid();
            var issueInfo = new IssueInfo()
            {
                Name = "Broken Window",
                Description = "on first floor building A, broken window"
            };
                
            var command = new CreateIssueCommand.Command(id, issueInfo);
            
            var handler = new CreateIssueCommand.Handler(_repository.Object);
        
            //Act
            var result = handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.Equal("1", result.Result.ToString());
        }

    }
}