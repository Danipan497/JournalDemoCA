using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Queries
{
    public record GetJournalEntryByIdQuery(int Id) : IRequest<JournalEntry>;
    
    public class GetJournalEntryByIdClass
    {
        public int Id { get; set; }

        public GetJournalEntryByIdClass(int id)
        {
            Id = id;
        }
    }

}
