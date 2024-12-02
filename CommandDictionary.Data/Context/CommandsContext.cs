using CommandDictionary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandDictionary.Data.Context;

public class CommandsContext : DbContext
{
    public DbSet<Application> Applications { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Command> Commands { get; set; }
    public DbSet<CommandEntry> Entries { get; set; }
    public DbSet<CommandVariable> Variables { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=.;Initial Catalog=CommandDictionary;Integrated Security=SSPI;Encrypt=False;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}


