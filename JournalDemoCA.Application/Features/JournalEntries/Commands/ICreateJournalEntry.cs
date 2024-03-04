using JournalDemoCA.Domain.Common.Entities;

namespace JournalDemoCA.Application.Features.JournalEntries.Commands
{
    public interface ICreateJournalEntry
    {
        List<JournalEntry> GetJournalEntries();
        JournalEntry InsertEntry(string firstName, string lastName);
    }
}