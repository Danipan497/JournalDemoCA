using JournalDemoCA.Application.Features.JournalEntries.Queries;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Handlers
{
    public class GetJournalEnrtyByIdHandler : IRequestHandler<GetJournalEntryByIdQuery, JournalEntry>
    {
        private readonly IMediator _mediator;

        public GetJournalEnrtyByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<JournalEntry> Handle(GetJournalEntryByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetJournalEntryListQuery());
            var output = results.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}
