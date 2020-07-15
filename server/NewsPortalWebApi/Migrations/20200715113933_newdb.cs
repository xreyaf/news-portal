using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortalWebApi.Migrations
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    public partial class Newdb : Migration
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    {
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        protected override void Up(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "News",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        protected override void Down(MigrationBuilder migrationBuilder)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "News",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Authors_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
