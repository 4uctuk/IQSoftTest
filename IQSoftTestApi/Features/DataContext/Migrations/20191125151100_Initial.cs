using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IQSoftTestApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstTestEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    Col2Item = table.Column<string>(nullable: true),
                    Col3Item = table.Column<string>(nullable: true),
                    Col4Item = table.Column<string>(nullable: true),
                    Col5Item = table.Column<string>(nullable: true),
                    Col6Item = table.Column<string>(nullable: true),
                    Col7Item = table.Column<string>(nullable: true),
                    Col8Item = table.Column<string>(nullable: true),
                    Col9Item = table.Column<string>(nullable: true),
                    Col10Item = table.Column<string>(nullable: true),
                    Col11Item = table.Column<string>(nullable: true),
                    Col12Item = table.Column<string>(nullable: true),
                    Col13Item = table.Column<string>(nullable: true),
                    Col14Item = table.Column<string>(nullable: true),
                    Col15Item = table.Column<string>(nullable: true),
                    Col16Item = table.Column<string>(nullable: true),
                    Col17Item = table.Column<string>(nullable: true),
                    Col18Item = table.Column<string>(nullable: true),
                    Col19Item = table.Column<string>(nullable: true),
                    Col20Item = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstTestEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecondTestEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    Col2Item = table.Column<string>(nullable: true),
                    Col3Item = table.Column<string>(nullable: true),
                    Col4Item = table.Column<string>(nullable: true),
                    Col5Item = table.Column<string>(nullable: true),
                    Col6Item = table.Column<string>(nullable: true),
                    Col7Item = table.Column<string>(nullable: true),
                    Col8Item = table.Column<string>(nullable: true),
                    Col9Item = table.Column<string>(nullable: true),
                    Col10Item = table.Column<string>(nullable: true),
                    Col11Item = table.Column<string>(nullable: true),
                    Col12Item = table.Column<string>(nullable: true),
                    Col13Item = table.Column<string>(nullable: true),
                    Col14Item = table.Column<string>(nullable: true),
                    Col15Item = table.Column<string>(nullable: true),
                    Col16Item = table.Column<string>(nullable: true),
                    Col17Item = table.Column<string>(nullable: true),
                    Col18Item = table.Column<string>(nullable: true),
                    Col19Item = table.Column<string>(nullable: true),
                    Col20Item = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondTestEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstTestEntities");

            migrationBuilder.DropTable(
                name: "SecondTestEntities");
        }
    }
}
