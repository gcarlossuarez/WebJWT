using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiJWT.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Habitantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "Id", "Habitantes", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5fa4e215-81b9-4ec9-a7c8-0f0664465def"), 46000000, "España" },
                    { new Guid("f3deefff-0d0a-4c58-9d55-ab912bd647d8"), 83000000, "Alemania" },
                    { new Guid("9233245c-c593-418f-8e50-3c4b4f34053f"), 65000000, "Francia" },
                    { new Guid("4ebfbe09-f1d5-4e5b-bfff-8cbc77d8485f"), 61000000, "Italia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
