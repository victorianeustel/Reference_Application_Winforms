using System.ComponentModel.DataAnnotations;

namespace CommandDictionary.Data.Models;
public class CommandVariable
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public int StartingIndex { get; set; }
    public int LastIndex { get; set; }
}
