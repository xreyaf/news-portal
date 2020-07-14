using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortalWebApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    NewsImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    MainText = table.Column<string>(type: "text", nullable: true),
                    Relevancy = table.Column<bool>(type: "boolean", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ChangingDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
