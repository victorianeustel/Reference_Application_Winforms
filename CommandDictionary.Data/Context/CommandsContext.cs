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
        modelBuilder.Entity<CommandEntry>()
            .Navigation(e => e.Command)
            .AutoInclude();
        modelBuilder.Entity<CommandEntry>()
            .Navigation(e => e.Application)
            .AutoInclude();
        modelBuilder.Entity<CommandEntry>()
            .Navigation(e => e.Category)
            .AutoInclude();

        modelBuilder.AddApplicationSeedData();
        modelBuilder.AddCategorySeedData();
        modelBuilder.AddCommandsSeedData();
        modelBuilder.AddEntriesSeedData();

        base.OnModelCreating(modelBuilder);
    }

}

public static class SeedData
{
    public static void AddApplicationSeedData(this ModelBuilder builder)
    {
        builder.Entity<Application>(a =>
        {
            a.HasData(
                new Application { Id = 1, Name = "PowerShell" },
                new Application { Id = 2, Name = "Command Prompt" }
                );
        });
    }

    public static void AddCategorySeedData(this ModelBuilder builder)
    {
        builder.Entity<Category>(c =>
        {
            c.HasData(
                new Category { Id = 1, Name = "Utility" },
                new Category { Id = 2, Name = "EF Core" },
                new Category { Id = 3, Name = "Network" },
                new Category { Id = 4, Name = "Active Directory" },
                new Category { Id = 5, Name = "Git" },
                new Category { Id = 6, Name = "Environment" }

                );
        });
    }

    public static void AddCommandsSeedData(this ModelBuilder builder)
    {
        var currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        builder.Entity<Command>(c =>
        {
            c.HasData(
                new Command() { Id = 1, CommandString = $"net user {currentUser} /domain" },
                new Command() { Id = 2, CommandString = "Test-NetConnection -ComputerName \"<computer-name-variable>\" -Port <port-variable> -InformationLevel \"Detailed\"" },
                new Command()
                {
                    Id = 3,
                    CommandString = "dotnet ef database update --context <db-context-name-variable>"
                },
            new Command() { Id = 4, CommandString = "dotnet ef migrations add <migration-name-variable>" },
            new Command() { Id = 5, CommandString = "dotnet ef dbcontext scaffold \"Data\", \"Source=<connection-string>\" Microsoft.EntityFrameworkCore.SqlServer\"" },
            new Command() { Id = 6, CommandString = "echo %<env-name-variable>% | clip" },
            new Command() { Id = 7, CommandString = "Set-Clipboard -Value $Env:App_Api_Token" },
            new Command() { Id = 8, CommandString = "git config --global http.sslVerify true" },
            new Command() { Id = 9, CommandString = "git push --mirror <target-repository-path>" },
         new Command() { Id = 10, CommandString = "net group <ad-group-name-variable> /domain" },
         new Command() { Id = 11, CommandString = "NET GROUP /DOMAIN" }
         );
        });
    }

    public static void AddEntriesSeedData(this ModelBuilder builder)
    {
        builder.Entity<CommandEntry>(c =>
        {
            c.HasData(
                new CommandEntry { Id = 1, Description = "Get user's group memberships", ApplicationId = 1, CategoryId = 4, CommandId = 1 },
                new CommandEntry { Id = 2, Description = "Test network status", ApplicationId = 1, CategoryId = 3, CommandId = 2 },
                new CommandEntry { Id = 3, Description = "Update database", ApplicationId = 1, CategoryId = 2, CommandId = 3 },
                new CommandEntry { Id = 4, Description = "Create migration", ApplicationId = 1, CategoryId = 2, CommandId = 4 },
                new CommandEntry { Id = 5, Description = "Scaffold database", ApplicationId = 1, CategoryId = 2, CommandId = 5 },
                new CommandEntry { Id = 6, Description = "Get all active directory groups", ApplicationId = 1, CategoryId = 4, CommandId = 11 },
                new CommandEntry { Id = 7, Description = "Copy environment variable to clipboard", ApplicationId = 1, CategoryId = 1, CommandId = 7 },
                new CommandEntry { Id = 8, Description = "Copy environment variable to clipboard", ApplicationId = 2, CategoryId = 1, CommandId = 6 },
                new CommandEntry { Id = 9, Description = "External git permissions", ApplicationId = 1, CategoryId = 5, CommandId = 8 },
                new CommandEntry { Id = 10, Description = "Clone repository to another repository", ApplicationId = 1, CategoryId = 5, CommandId = 9 },
                new CommandEntry { Id = 11, Description = "Get members of AD group", ApplicationId = 1, CategoryId = 4, CommandId = 10 }
                );
        });
    }
}


