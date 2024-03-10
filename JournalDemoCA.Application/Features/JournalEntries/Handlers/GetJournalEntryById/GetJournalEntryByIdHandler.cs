using JournalDemoCA.Application.Features.JournalEntries.Queries.GetJournalEntryById;
using JournalDemoCA.Application.Features.JournalEntries.Queries.GetJournalEntryList;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;

namespace JournalDemoCA.Application.Features.JournalEntries.Handlers.GetJournalEntryById
{
    public class GetJournalEntryByIdHandler : IRequestHandler<GetJournalEntryByIdQuery, JournalEntry>
    {
        private readonly IMediator _mediator;

        public GetJournalEntryByIdHandler(IMediator mediator)
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
