using CommandDictionary.Converters;
using System.Text.Json.Serialization;

namespace CommandDictionary.Models;

[JsonConverter(typeof(ApplicationJsonConverter))]
public enum Application
{
    PowerShell,
    CommandPrompt,
}
