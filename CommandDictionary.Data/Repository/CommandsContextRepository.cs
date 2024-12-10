using CommandDictionary.Data.Context;
using CommandDictionary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandDictionary.Data.Repository;
public class CommandsContextRepository(CommandsContext context) : ICommandsContextRepository
{
    public async Task<IEnumerable<CommandEntry>> GetCommandEntries()
    {
        var result = await context.Entries
            .ToListAsync();
        return result ?? [];
    }
    public async Task<IEnumerable<Category>> GetCategoryTypes()
    {
        var result = await context.Categories
            .ToListAsync();
        return result ?? [];
    }
    public async Task<IEnumerable<Application>> GetApplicationTypes()
    {
        var result = await context.Applications
            .ToListAsync();
        return result ?? [];
    }
}
