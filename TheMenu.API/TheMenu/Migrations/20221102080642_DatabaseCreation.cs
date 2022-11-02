using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheMenu.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegisteredById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastChangeById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedAt", "LastChangeById", "Name", "RegisteredById", "UpdatedAt" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Second Product", null, null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedAt", "LastChangeById", "Name", "RegisteredById", "UpdatedAt" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "First Product", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
