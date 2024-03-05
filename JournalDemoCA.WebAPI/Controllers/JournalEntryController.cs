using JournalDemoCA.Application.Features.JournalEntries.Commands;
using JournalDemoCA.Application.Features.JournalEntries.Queries;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;
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

        // POST api/<PersonController>
        [HttpPost]
        public async Task<JournalEntry> Post([FromBody] JournalEntry value)
        {
            var model = new InsertJournalEntryCommand(value.FirstName, value.LastName);
            return await _mediator.Send(model);
        }
    }
}
