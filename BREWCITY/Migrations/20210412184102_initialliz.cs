using Microsoft.EntityFrameworkCore.Migrations;

namespace BREWCITY.Migrations
{
    public partial class initialliz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cc6b7bf-b205-4c46-875e-a6104890e1ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89cbec7d-5cf8-4022-ba12-2fcb37ab6b22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eecf4d73-c432-4f07-84e6-5e212f81a11e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a831dfe5-33b0-4da6-ac42-e072fd16cb71", "9f2693f8-6317-4a1e-8940-0b50c1db78c0", "Brewery", "BREWERY" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89bbdce1-2f4c-4a57-b6c7-310d8633499a", "fcd3f4ec-85f1-4003-b553-45e5e775ebca", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "98fff864-63ea-4be2-b82a-c662e44aa00d", "8ef636d7-cfeb-4e9a-8c5c-f5c01c9ea466", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89bbdce1-2f4c-4a57-b6c7-310d8633499a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98fff864-63ea-4be2-b82a-c662e44aa00d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a831dfe5-33b0-4da6-ac42-e072fd16cb71");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eecf4d73-c432-4f07-84e6-5e212f81a11e", "2242ea70-d65a-492e-be94-164ef87a9bf0", "Brewery", "BREWERY" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89cbec7d-5cf8-4022-ba12-2fcb37ab6b22", "71462a8c-86b1-4f25-9504-a695dc493cff", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cc6b7bf-b205-4c46-875e-a6104890e1ee", "0bed83ab-1ae7-4930-861f-fea445b8fef5", "Admin", "ADMIN" });
        }
    }
}
