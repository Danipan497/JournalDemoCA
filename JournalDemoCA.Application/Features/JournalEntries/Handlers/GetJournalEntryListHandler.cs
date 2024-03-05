using JournalDemoCA.Application.Features.JournalEntries.Commands;
using JournalDemoCA.Application.Features.JournalEntries.Queries;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Handlers
{
    public class GetJournalEntryListHandler : IRequestHandler<GetJournalEntryListQuery, List<JournalEntry>>
    {
        private readonly ICreateJournalEntry _createJournalEntry;

        public GetJournalEntryListHandler(ICreateJournalEntry createJournalEntry)
        {
            _createJournalEntry = createJournalEntry;
        }

        public Task<List<JournalEntry>> Handle(GetJournalEntryListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_createJournalEntry.GetJournalEntries());
        }
    }
}
