using JournalDemoCA.Domain.Common.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Commands.PostJournalEntry
{
    public record InsertJournalEntryCommand(string FirstName, string LastName) : IRequest<JournalEntry>
    {
        public class InsertJournalEntryCommandClass : IRequest<JournalEntry>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public InsertJournalEntryCommandClass(string firstname, string lastname)
            {
                FirstName = firstname;
                LastName = lastname;
            }
        }
    }
}
