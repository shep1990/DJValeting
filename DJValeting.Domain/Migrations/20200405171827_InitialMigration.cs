using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DJValeting.Domain.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DJValeting",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    BookingDate = table.Column<DateTime>(nullable: false),
                    Flexibility = table.Column<int>(nullable: false),
                    VehicleSize = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DJValeting", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DJValeting_Id",
                table: "DJValeting",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DJValeting");
        }
    }
}
