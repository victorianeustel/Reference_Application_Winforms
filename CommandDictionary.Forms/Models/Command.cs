using System.Text.Json.Serialization;

namespace CommandDictionary.Models;
public class Command
{
    [JsonPropertyName("commandString")]
    public required string CommandString { get; set; }
    [JsonPropertyName("variables")]
    public IEnumerable<CommandVariable> Variables { get; set; } = new List<CommandVariable>();
}
