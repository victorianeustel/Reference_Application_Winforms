namespace CommandDictionary.Forms.Models;

//[JsonConverter(typeof(CategoryJsonConverter))]
public class Category
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
