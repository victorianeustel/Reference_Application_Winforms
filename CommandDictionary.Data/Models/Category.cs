using System.ComponentModel.DataAnnotations;

namespace CommandDictionary.Data.Models;

public class Category
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
