
using System.ComponentModel.DataAnnotations;

namespace CommandDictionary.Data.Models;

public class CommandEntry
{
    [Key]
    public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public long ApplicationId { get; set; }
    public long CategoryId { get; set; }
    public long CommandId { get; set; }

    public virtual Category Category { get; set; } = null!;
    public virtual Application Application { get; set; } = null!;
    public virtual Command Command { get; set; } = null!;
}
