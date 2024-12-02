using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.IdentityModel.Tokens;
using System.Net;

#nullable disable

namespace CommandDictionary.Data.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Category_And_Application_Types : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                column: "Name",
                values: new string[]
                {
                    "Utility",
                    "EF Core",
                    "Network",
                    "Permissions",
                    "Git",
                    "Environment"
                }
            );

            migrationBuilder.InsertData(
                table: "Applications",
                column: "Name",
                values: new string[]
                {
                    "PowerShell",
                    "Command Prompt"
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
