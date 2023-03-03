using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookish.Migrations
{
    /// <inheritdoc />
    public partial class CopiesTableAmendment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Copies",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Copies");
        }
    }
}
