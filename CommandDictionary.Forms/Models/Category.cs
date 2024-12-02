using CommandDictionary.Converters;
using System.Text.Json.Serialization;

namespace CommandDictionary.Models;

[JsonConverter(typeof(CategoryJsonConverter))]
public enum Category
{
    Utility,
    EFCore,
    Network,
    Permissions,
    Git,
    Environment
}
