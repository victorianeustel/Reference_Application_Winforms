using CommandDictionary.Data.Models;

namespace CommandDictionary.Data.Repository;
public interface ICommandsContextRepository
{
    IEnumerable<CommandEntry> GetCommandEntries();
    IEnumerable<Category> GetCategoryTypes();
    IEnumerable<Application> GetApplicationTypes();
    CommandEntry AddCommand(CommandEntry newCommand);
    bool UpdateCommand(CommandEntry updatedCommand);
    bool DeleteCommand(long commandId);

}
