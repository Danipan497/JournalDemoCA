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
    }
}
