using CommandDictionary.Data.Context;
using CommandDictionary.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CommandDictionary.Data.Repository;
public class CommandsContextRepository(CommandsContext context) : ICommandsContextRepository
{
    public IEnumerable<CommandEntry> GetCommandEntries()
    {
        var result = context.Entries
            .Include(x => x.Command)
            .Include(c => c.Application)
            .Include(c => c.Category)
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

    public CommandEntry AddCommand(CommandEntry newCommand)
    {
        try
        {
            var obj = context.Entries.Add(newCommand);
            context.SaveChanges();

            return obj.Entity;
        }
        catch (Exception ex)
        {
            // Log
            Console.Out.WriteLine(ex.Message);
            throw;
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

    public CommandEntry InsertOrUpdate(CommandEntry entry)
    {
        var existingEntry = context.Entries.Find(entry.Id);
        if (existingEntry == null)
        {
            context.Add(entry);
        }
        else
        {
            context.Entry(existingEntry).CurrentValues.SetValues(entry);
        }
        context.SaveChanges();

        existingEntry = context.Entries.Find(entry.Id);

        return existingEntry!;
    }
    private CommandEntry? TryGetCommandEntryById(long id)
    {
        var entry = context.Entries
            .Single(b => b.Id == id);

        return entry;
    }
}
