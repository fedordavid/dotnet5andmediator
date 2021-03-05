using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ActionResult<IssueView[]>> GetAllIssues()
        {
           var response = await _mediator.Send(new GetIssuesQuery.Query());
           return response == null ? NotFound() : Ok(Response);
        }
    }
}