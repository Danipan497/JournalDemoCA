using JournalDemoCA.Application.Features.JournalEntries.Commands;
using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Handlers
{
    public class InsertJournalEntryHandler : IRequestHandler<InsertJournalEntryCommand, JournalEntry>
    {
        private readonly ICreateJournalEntry _createJournalEntry;

        public InsertJournalEntryHandler(ICreateJournalEntry createJournalEntry)
        {
            _createJournalEntry = createJournalEntry;
        }

        public Task<JournalEntry> Handle(InsertJournalEntryCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_createJournalEntry.InsertEntry(request.FirstName, request.LastName));
        }
    }
}
