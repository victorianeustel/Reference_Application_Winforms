using CommandDictionary.Data.Context;
using CommandDictionary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandDictionary.Data.Repository;
public class CommandsContextRepository(CommandsContext context) : ICommandsContextRepository
{
    public IEnumerable<CommandEntry> GetCommandEntries()
    {
        var result = context.Entries
            .ToList();
        return result ?? [];
    }
    public IEnumerable<Category> GetCategoryTypes()
    {
        var result =  context.Categories
            .ToList();
        return result ?? [];
    }
    public IEnumerable<Application> GetApplicationTypes()
    {
        var result = context.Applications
            .ToList();
        return result ?? [];
    }

    public bool UpdateCommand(CommandEntry updatedCommand)
    {
        try
        {
            var entry = TryGetCommandEntryById(updatedCommand.Id);

            if (entry == null)
            {
                return false;
            }

            entry.Application = updatedCommand.Application;
            entry.Category = updatedCommand.Category;
            entry.Command = updatedCommand.Command;

            context.SaveChanges();

            return true;
        }
        catch(Exception ex)
        {
            // Log
            Console.Out.WriteLine(ex.Message);
            return false;
        }
    }

    public bool AddCommand(CommandEntry newCommand)
    {
        try
        {
            context.Entries.Add(newCommand);
            context.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            // Log
            Console.Out.WriteLine(ex.Message);
            return false;
        }
    }

    public bool DeleteCommand(long commandId)
    {
        try
        {
            //CommandEntry command = new CommandEntry() { Id = commandId };
            //context.Entries.Attach(command);
            //context.Entries.Remove(command);
            var entry = TryGetCommandEntryById(commandId);

            if ( entry == null)
            {
                return false;
            }

            context.Entries.Remove(entry);

            context.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            // Log
            Console.Out.WriteLine(ex.Message);
            return false;
        }
    }

    private CommandEntry? TryGetCommandEntryById(long id)
    {
        var entry = context.Entries
            .Single(b => b.Id == id);

        return entry;
    }
}
