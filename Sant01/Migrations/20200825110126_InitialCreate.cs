using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sant01.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 32, nullable: true),
                    Surename = table.Column<string>(maxLength: 32, nullable: true),
                    PersonIdentificationCode = table.Column<long>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DOB", "Name", "PersonIdentificationCode", "Status", "Surename" },
                values: new object[,]
                {
                    { 1, "Tilto g. 2-2", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Jonas", 30101010001L, (byte)0, "Jonaitis" },
                    { 2, "Milto g. 2-2", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Petras", 30202020002L, (byte)0, "Petraitis" },
                    { 3, "Bilto g. 2-2", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Kazys", 30303030003L, (byte)0, "Kazaitis" },
                    { 4, "Silto g. 2-2", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Tomas", 30404040004L, (byte)1, "Tomaitis" },
                    { 5, "Rilto g. 2-2", new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Arturas", 30505050005L, (byte)1, "Arturaitis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
