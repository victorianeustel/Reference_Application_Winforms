using System.ComponentModel.DataAnnotations;

namespace CommandDictionary.Data.Models;

public class Application
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;

}
