using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Queries.GetJournalEntryList
{
    public record GetJournalEntryListQuery() : IRequest<List<JournalEntry>>;
}
