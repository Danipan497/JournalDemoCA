using JournalDemoCA.Application.Features.JournalEntries.Commands.CreateJournalEntry.Interface;
using JournalDemoCA.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalDemoCA.Application.Features.JournalEntries.Commands.CreateJournalEntry
{
    public class CreateJournalEntryCommand : ICreateJournalEntry
    {
        private List<JournalEntry> entry = new();
        public CreateJournalEntryCommand()
        {
            entry.Add(new JournalEntry { Id = 1, FirstName = "Daniel", LastName = "Pandza" });
            entry.Add(new JournalEntry { Id = 2, FirstName = "Paniel", LastName = "Dandza" });
        }

        public List<JournalEntry> GetJournalEntries()
        {
            return entry;
        }

        public JournalEntry InsertEntry(string firstName, string lastName)
        {
            JournalEntry j = new() { FirstName = firstName, LastName = lastName };
            j.Id = entry.Max(x => x.Id) + 1;
            entry.Add(j);
            return j;
        }
    }
}
