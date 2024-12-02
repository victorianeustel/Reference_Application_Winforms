using System.Text.Json.Serialization;
using System.Text.Json;
using CommandDictionary.Models;

namespace CommandDictionary.Converters;
public class CategoryJsonConverter : JsonConverter<Category>
{
    public override Category Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
            (Category)Enum.Parse(typeof(Category), reader.GetString()!);

    public override void Write(
        Utf8JsonWriter writer,
        Category categoryValue,
        JsonSerializerOptions options) =>
            writer.WriteStringValue(nameof(categoryValue));
}

