using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lounge.Web.Migrations
{
    /// <inheritdoc />
    public partial class ThreeScoresPerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "TableScores",
                newName: "Score3");

            migrationBuilder.AddColumn<int>(
                name: "Score1",
                table: "TableScores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score2",
                table: "TableScores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score1",
                table: "TableScores");

            migrationBuilder.DropColumn(
                name: "Score2",
                table: "TableScores");

            migrationBuilder.RenameColumn(
                name: "Score3",
                table: "TableScores",
                newName: "Score");
        }
    }
}
