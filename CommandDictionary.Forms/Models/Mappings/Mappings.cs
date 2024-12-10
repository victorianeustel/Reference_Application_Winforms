namespace CommandDictionary.Forms.Models.Mappings;
public static class Mappings
{
    #region Data --> Forms
    public static CommandEntry MapToCommandEntry(this Data.Models.CommandEntry entry)
    {
        return new CommandEntry()
        {
            Id = entry.Id,
            Category = entry.Category.MapToCategory(),
            Application = entry.Application.MapToApplication(),
            Command = entry.Command.MapToCommand(),
            Description = entry.Description,
        };
    }

    public static IEnumerable<CommandEntry> MapToCommandEntries(this IEnumerable<Data.Models.CommandEntry> entries)
    {
        foreach (var entry in entries)
        {
            yield return entry.MapToCommandEntry();
        }
    }

    public static Category MapToCategory(this Data.Models.Category entry)
    {
        return new Category()
        {
            Id = entry.Id,
            Name = entry.Name,
        };
    }

    public static Application MapToApplication(this Data.Models.Application entry)
    {
        return new Application()
        {
            Id = entry.Id,
            Name = entry.Name,
        };
    }

    public static Command MapToCommand(this Data.Models.Command entry)
    {
        return new Command()
        {
            Id = entry.Id,
            CommandString = entry.CommandString,
            Variables = entry.Variables.MapToListCommandVariable()
        };
    }

    public static CommandVariable MapToCommandVariable(this Data.Models.CommandVariable entry)
    {
        return new CommandVariable()
        {
            Id = entry.Id,
            Name = entry.Name,
            DisplayName = entry.DisplayName,
            StartingIndex = entry.StartingIndex,
            LastIndex = entry.LastIndex,
        };
    }

    public static IEnumerable<CommandVariable> MapToListCommandVariable(this IEnumerable<Data.Models.CommandVariable> entries)
    {
        foreach (var entry in entries)
        {
            yield return entry.MapToCommandVariable();
        }
    }
    #endregion

    #region Forms --> Data
    public static Data.Models.CommandEntry MapToDataCommandEntry(this CommandEntry entry)
    {
        return new Data.Models.CommandEntry()
        {
            Id = entry.Id,
            CategoryId = entry.Category.Id,
            ApplicationId = entry.Application.Id,
            Command = entry.Command.MapToDataCommand(),
            Description = entry.Description,
        };
    }

    public static Data.Models.Command MapToDataCommand(this Command entry)
    {
        return new Data.Models.Command()
        {
            Id = entry.Id,
            CommandString = entry.CommandString,
        };
    }
    #endregion
}
