using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortalWebApi.Migrations
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    public partial class Init : Migration
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
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NewsImage = table.Column<byte[]>(nullable: true),
                    MainText = table.Column<string>(nullable: true),
                    Relevancy = table.Column<bool>(nullable: false),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    ChangingDateTime = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
