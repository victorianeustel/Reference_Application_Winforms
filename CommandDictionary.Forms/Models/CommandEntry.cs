using System.Text.Json.Serialization;
using Application = CommandDictionary.Forms.Models.Application;

namespace CommandDictionary.Forms.Models;

public class CommandEntry
{
    public long Id { get; set; }
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
            Text = Application.Name,
            Tag = this
        };

        return item;
    }


}
