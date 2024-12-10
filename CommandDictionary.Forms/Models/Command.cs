using System.Text.Json.Serialization;

namespace CommandDictionary.Forms.Models;
public class Command
{
    public long Id { get; set; }
    [JsonPropertyName("commandString")]
    public required string CommandString { get; set; }
    [JsonPropertyName("variables")]
    public IEnumerable<CommandVariable> Variables { get; set; } = [];
}
