using Microsoft.EntityFrameworkCore.Migrations;

namespace ChildStudy.Migrations
{
    public partial class RaitingsForStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Raitings_RaitingId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Ways_wayId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_RaitingId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_wayId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "RaitingId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "wayId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Raitings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Raitings_StudentId",
                table: "Raitings",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Raitings_Students_StudentId",
                table: "Raitings",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Raitings_Students_StudentId",
                table: "Raitings");

            migrationBuilder.DropIndex(
                name: "IX_Raitings_StudentId",
                table: "Raitings");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Raitings");

            migrationBuilder.AddColumn<int>(
                name: "RaitingId",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wayId",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_RaitingId",
                table: "Students",
                column: "RaitingId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_wayId",
                table: "Students",
                column: "wayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Raitings_RaitingId",
                table: "Students",
                column: "RaitingId",
                principalTable: "Raitings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Ways_wayId",
                table: "Students",
                column: "wayId",
                principalTable: "Ways",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
