﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTeplApp.Migrations
{
    /// <inheritdoc />
    public partial class userID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Variants",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Variants");
        }
    }
}
