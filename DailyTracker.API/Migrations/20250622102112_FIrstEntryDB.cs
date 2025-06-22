using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DailyTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class FIrstEntryDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1693788f-ca13-4ed0-8b5b-074389d2a4cd"), "No sugar" },
                    { new Guid("260f704d-8bd5-45ed-bf6a-9fa9f6607d92"), "No alcohol" },
                    { new Guid("87420699-f622-4a17-858f-c6363de440c1"), "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2562d8f5-e514-4af4-b803-0a29fbbb9400"), "Cris" },
                    { new Guid("a48e6f70-a9e0-44ca-9c8e-9ef8a70ef8d8"), "Tess" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1693788f-ca13-4ed0-8b5b-074389d2a4cd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("260f704d-8bd5-45ed-bf6a-9fa9f6607d92"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87420699-f622-4a17-858f-c6363de440c1"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("2562d8f5-e514-4af4-b803-0a29fbbb9400"));

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: new Guid("a48e6f70-a9e0-44ca-9c8e-9ef8a70ef8d8"));
        }
    }
}
