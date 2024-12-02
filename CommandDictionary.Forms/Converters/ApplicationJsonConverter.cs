using System.Text.Json.Serialization;
using System.Text.Json;
using Application = CommandDictionary.Models.Application;

namespace CommandDictionary.Converters;
public class ApplicationJsonConverter : JsonConverter<Application>
{
    public override Application Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
            (Application)Enum.Parse(typeof(Application), reader.GetString()!);

    public override void Write(
        Utf8JsonWriter writer,
        Application applicationValue,
        JsonSerializerOptions options) =>
            writer.WriteStringValue(nameof(applicationValue));
}

