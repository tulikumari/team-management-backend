using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamManagerBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeamMemberModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "TeamMembers",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "TeamMembers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TeamMembers",
                newName: "Details");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "TeamMembers",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "TeamMembers");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "TeamMembers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TeamMembers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "TeamMembers",
                newName: "Email");
        }
    }
}
