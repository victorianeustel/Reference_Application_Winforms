using System.Text.Json.Serialization;
using Application = CommandDictionary.Models.Application;

namespace CommandDictionary.Models;

public class CommandEntry
{
    [JsonPropertyName("application")]
    public required Application Application { get; set; }

    [JsonPropertyName("category")]
    public required Category Category { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("command")]
    public required Command Command { get; set; }

    public ListViewItem ToListViewItem()
    {
        ListViewItem item = new ListViewItem
        {
            Text = Enum.GetName(Application),
            Tag = this
        };

        return item;
    }
}
