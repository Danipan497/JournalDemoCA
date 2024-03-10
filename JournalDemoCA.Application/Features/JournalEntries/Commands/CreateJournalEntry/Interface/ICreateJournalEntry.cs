using JournalDemoCA.Domain.Common.Entities;

namespace JournalDemoCA.Application.Features.JournalEntries.Commands.CreateJournalEntry.Interface
{
    public interface ICreateJournalEntry
    {
        List<JournalEntry> GetJournalEntries();
        JournalEntry InsertEntry(string firstName, string lastName);
    }
}