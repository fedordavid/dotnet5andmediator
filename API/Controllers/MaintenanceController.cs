using System;
using System.Threading.Tasks;
using Application.Commands;
using Application.Pagination;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.Issues;

namespace API.Controllers
{
    public class MaintenanceController : ControllerBase
    {
        public IMediator _mediator { get; }

        public MaintenanceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("maintenance/issues")]
        public async Task<ActionResult<PagedResult<IssueView>>> GetAllIssues(int page = 0, int pageSize = 50)
        {
           var result = await _mediator.Send(new GetIssuesQuery.Query());
           return result == null ? NotFound() : Ok(await result.GetPage(page, pageSize));
        }
        
        [HttpGet("maintenance/issues/{id}")]
        public async Task<ActionResult<IssueView[]>> GetIssueById(Guid id)
        {
            var result = await _mediator.Send(new GetIssueByIdQuery.Query(id));
            return result == null ? NotFound() : Ok(result);
        }
        
        [HttpPost("maintenance/issues")]
        public async Task<ActionResult> CreateIssue([FromBody] IssueInfo info)
        {
            var id = Guid.NewGuid();
            var result = await _mediator.Send(new CreateIssueCommand.Command(id, info));
            return CreatedAtAction(nameof(GetIssueById), new { id }, null);
        }
    }
}