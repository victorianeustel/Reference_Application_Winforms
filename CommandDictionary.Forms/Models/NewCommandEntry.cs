using CommandDictionary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDictionary.Forms.Models;
internal class NewCommandEntry
{
    public long ApplicationId { get; set; }
    public long CategoryId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string CommandString { get; set; } = string.Empty;

    public Data.Models.CommandEntry ToDataCommandEntry()
    {
        return new Data.Models.CommandEntry()
        {
            ApplicationId = ApplicationId,
            CategoryId = CategoryId,
            Description = Description,
            Command = new Data.Models.Command()
            {
                CommandString = CommandString
            }
        };
    }
}
