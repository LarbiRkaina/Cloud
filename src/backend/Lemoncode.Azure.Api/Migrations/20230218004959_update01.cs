﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lemoncode.Azure.Api.Migrations
{
    /// <inheritdoc />
    public partial class update01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "DownloadUrl",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Playability",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "PosterUrl",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Game");

            migrationBuilder.AddColumn<string>(
                name: "Filename",
                table: "Screenshot",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Screenshot",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filename",
                table: "Screenshot");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Screenshot");

            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DownloadUrl",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Playability",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PosterUrl",
                table: "Game",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
