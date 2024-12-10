namespace CommandDictionary.Forms.Models;

//[JsonConverter(typeof(ApplicationJsonConverter))]
public class Application
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
