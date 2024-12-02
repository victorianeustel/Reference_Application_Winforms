namespace CommandDictionary.Models;
public class CommandVariable
{
    public required string Name { get; set; }
    public required string DisplayName { get; set; }
    public int StartingIndex { get; set; }
    public int LastIndex { get; set; }
}
