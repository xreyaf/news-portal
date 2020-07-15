using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortalWebApi.Migrations
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    public partial class Initial : Migration
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    {
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        protected override void Up(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    NewsImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    MainText = table.Column<string>(type: "text", nullable: true),
                    Relevancy = table.Column<bool>(type: "boolean", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ChangingDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");
        }

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        protected override void Down(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
