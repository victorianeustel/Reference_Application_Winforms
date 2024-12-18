using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommandDictionary.Data.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "PowerShell" },
                    { 2L, "Command Prompt" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Utility" },
                    { 2L, "EF Core" },
                    { 3L, "Network" },
                    { 4L, "Active Directory" },
                    { 5L, "Git" },
                    { 6L, "Environment" }
                });

            migrationBuilder.InsertData(
                table: "Commands",
                columns: new[] { "Id", "CommandString" },
                values: new object[,]
                {
                    { 1L, "net user SBTNET\\vneustel /domain" },
                    { 2L, "Test-NetConnection -ComputerName \"<computer-name-variable>\" -Port <port-variable> -InformationLevel \"Detailed\"" },
                    { 3L, "dotnet ef database update --context <db-context-name-variable>" },
                    { 4L, "dotnet ef migrations add <migration-name-variable>" },
                    { 5L, "dotnet ef dbcontext scaffold \"Data\", \"Source=<connection-string>\" Microsoft.EntityFrameworkCore.SqlServer\"" },
                    { 6L, "echo %<env-name-variable>% | clip" },
                    { 7L, "Set-Clipboard -Value $Env:App_Api_Token" },
                    { 8L, "git config --global http.sslVerify true" },
                    { 9L, "git push --mirror <target-repository-path>" },
                    { 10L, "net group <ad-group-name-variable> /domain" },
                    { 11L, "NET GROUP /DOMAIN" }
                });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "Id", "ApplicationId", "CategoryId", "CommandId", "Description" },
                values: new object[,]
                {
                    { 1L, 1L, 4L, 1L, "Get user's group memberships" },
                    { 2L, 1L, 3L, 2L, "Test network status" },
                    { 3L, 1L, 2L, 3L, "Update database" },
                    { 4L, 1L, 2L, 4L, "Create migration" },
                    { 5L, 1L, 2L, 5L, "Scaffold database" },
                    { 6L, 1L, 4L, 11L, "Get all active directory groups" },
                    { 7L, 1L, 1L, 7L, "Copy environment variable to clipboard" },
                    { 8L, 2L, 1L, 6L, "Copy environment variable to clipboard" },
                    { 9L, 1L, 5L, 8L, "External git permissions" },
                    { 10L, 1L, 5L, 9L, "Clone repository to another repository" },
                    { 11L, 1L, 4L, 10L, "Get members of AD group" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Entries",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Commands",
                keyColumn: "Id",
                keyValue: 11L);
        }
    }
}
