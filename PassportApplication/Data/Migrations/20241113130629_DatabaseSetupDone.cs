using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassportApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSetupDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClass_GymClasses_GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserGymClass_GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropColumn(
                name: "GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ApplicationUserApplicationUserGymClass",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookedClassesUserId = table.Column<int>(type: "int", nullable: false),
                    BookedClassesClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserApplicationUserGymClass", x => new { x.ApplicationUsersId, x.BookedClassesUserId, x.BookedClassesClassId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserApplicationUserGymClass_ApplicationUserGymClass_BookedClassesUserId_BookedClassesClassId",
                        columns: x => new { x.BookedClassesUserId, x.BookedClassesClassId },
                        principalTable: "ApplicationUserGymClass",
                        principalColumns: new[] { "UserId", "ClassId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserApplicationUserGymClass_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserGymClassGymClass",
                columns: table => new
                {
                    GymClassesId = table.Column<int>(type: "int", nullable: false),
                    AttendeesUserId = table.Column<int>(type: "int", nullable: false),
                    AttendeesClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGymClassGymClass", x => new { x.GymClassesId, x.AttendeesUserId, x.AttendeesClassId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGymClassGymClass_ApplicationUserGymClass_AttendeesUserId_AttendeesClassId",
                        columns: x => new { x.AttendeesUserId, x.AttendeesClassId },
                        principalTable: "ApplicationUserGymClass",
                        principalColumns: new[] { "UserId", "ClassId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGymClassGymClass_GymClasses_GymClassesId",
                        column: x => x.GymClassesId,
                        principalTable: "GymClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserApplicationUserGymClass_BookedClassesUserId_BookedClassesClassId",
                table: "ApplicationUserApplicationUserGymClass",
                columns: new[] { "BookedClassesUserId", "BookedClassesClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGymClassGymClass_AttendeesUserId_AttendeesClassId",
                table: "ApplicationUserGymClassGymClass",
                columns: new[] { "AttendeesUserId", "AttendeesClassId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserApplicationUserGymClass");

            migrationBuilder.DropTable(
                name: "ApplicationUserGymClassGymClass");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "GymClassId",
                table: "ApplicationUserGymClass",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGymClass_GymClassId",
                table: "ApplicationUserGymClass",
                column: "GymClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClass_GymClasses_GymClassId",
                table: "ApplicationUserGymClass",
                column: "GymClassId",
                principalTable: "GymClasses",
                principalColumn: "Id");
        }
    }
}
