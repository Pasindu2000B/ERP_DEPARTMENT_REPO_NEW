using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoginManagement.DataService.Migrations
{
    /// <inheritdoc />
    public partial class y : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8fe74038-5890-447b-8391-0a28f07b7307"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d3dede8b-69b6-4650-94cb-0a9751595480"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9b2d8feb-d603-46da-83b6-f43376752675"), null, "Coordinator", "COORDINATOR" },
                    { new Guid("f1f8b25a-bd71-4f05-8d74-ef7271b2a7c1"), null, "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9b2d8feb-d603-46da-83b6-f43376752675"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f1f8b25a-bd71-4f05-8d74-ef7271b2a7c1"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8fe74038-5890-447b-8391-0a28f07b7307"), null, "Coordinator", "COORDINATOR" },
                    { new Guid("d3dede8b-69b6-4650-94cb-0a9751595480"), null, "Student", "STUDENT" }
                });
        }
    }
}
