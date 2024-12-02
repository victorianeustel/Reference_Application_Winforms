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
            @"Server=(localdb)\mssqllocaldb;Database=CommandDictionary;ConnectRetryCount=0");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Command>()
        //    .HasMany(e => e.Variables)
        //    .WithOne(e => e)
        //    .HasForeignKey(e => e)

        base.OnModelCreating(modelBuilder);
    }

}


