using CommandDictionary.Forms.Models;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace CommandDictionary.Helpers;

public static class JsonDataHelper
{
    public static readonly string JsonPath = $"{Directory.GetCurrentDirectory()}/Data/data.json";

    private readonly static IEnumerable<CommandEntry> commandEntries = ReadJsonFile();

    public static IEnumerable<CommandEntry> GetCommands()
    {
        return commandEntries;
    } 
    private static IEnumerable<CommandEntry> ReadJsonFile()
    {
        string jsonFile = File.ReadAllText(JsonPath);

        if (string.IsNullOrEmpty(jsonFile))
        {
            return [];
        }

        var jsonResult =
             JsonSerializer.Deserialize<IEnumerable<CommandEntry>>(jsonFile);

        return jsonResult ?? [];
    }

    public static void UpdateJsonFile(IEnumerable<CommandEntry> commands)
    {
        try
        {
            string json = JsonSerializer.Serialize(commands);
            File.WriteAllText(JsonPath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void AddAndUpdateEntries(CommandEntry command, List<CommandEntry> entries)
    {
        entries.Add(command);
        UpdateJsonFile(entries);
    }
}
