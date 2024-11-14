using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassportApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangingUserIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ApplicationUserGymClass",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OldUserId",
                table: "ApplicationUserGymClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass",
                columns: new[] { "OldUserId", "ClassId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropColumn(
                name: "OldUserId",
                table: "ApplicationUserGymClass");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ApplicationUserGymClass",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserGymClass",
                table: "ApplicationUserGymClass",
                columns: new[] { "UserId", "ClassId" });
        }
    }
}
