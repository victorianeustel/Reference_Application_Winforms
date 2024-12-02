using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace CommandDictionary.Data.Models;
public class Command
{
    [Key]
    public long Id { get; set; }

    public string CommandString { get; set; } = string.Empty;

    public virtual ObservableCollectionListSource<CommandVariable> Variables { get; } = [];
}
