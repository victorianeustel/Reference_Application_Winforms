using CommandDictionary.Data.Models;

namespace CommandDictionary.Data.Repository;
public interface ICommandsContextRepository
{
    Task<IEnumerable<CommandEntry>> GetCommandEntries();
    Task<IEnumerable<Category>> GetCategoryTypes();
    Task<IEnumerable<Application>> GetApplicationTypes();
}
