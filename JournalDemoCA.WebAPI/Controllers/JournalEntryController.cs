using JournalDemoCA.Application.Features.JournalEntries.Queries;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JournalDemoCA.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JournalEntryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<JournalEntryController>
        [HttpGet]
        public async Task<List<JournalEntry>> Get()
        {
            return await _mediator.Send(new GetJournalEntryListQuery());
        }

        // GET: api/<JournalEntryController>/5
        [HttpGet("{id}")]
        public async Task<JournalEntry> Get(int id)
        {
            return await _mediator.Send(new GetJournalEntryByIdQuery(id));
        }
    }
}
