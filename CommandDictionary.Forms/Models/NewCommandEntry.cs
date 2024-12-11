using CommandDictionary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDictionary.Forms.Models;
internal class NewCommandEntry
{
    public long Id { get; set; } = -1;
    public long ApplicationId { get; set; }
    public long CategoryId { get; set; }
    public string Description { get; set; } = string.Empty;
    public long CommandId { get; set; } = -1;
    public string CommandString { get; set; } = string.Empty;

    public Data.Models.CommandEntry ToDataCommandEntry()
    {
        var command = CommandId == -1
            ? new Data.Models.Command()
            {
                CommandString = CommandString
            }
            : new Data.Models.Command()
            {
                Id = CommandId,
                CommandString = CommandString
            };

        return new Data.Models.CommandEntry()
        {
            Id = Id,
            ApplicationId = ApplicationId,
            CategoryId = CategoryId,
            CommandId = CommandId,
            Description = Description,
            Command = command
        };
    }
}
