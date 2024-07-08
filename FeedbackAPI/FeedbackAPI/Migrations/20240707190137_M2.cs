using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedbackAPI.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Message");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostDate",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
