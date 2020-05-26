using Microsoft.EntityFrameworkCore.Migrations;

namespace gettingstarted_aspnet_identity.Migrations
{
    public partial class InsertRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70aab4a6-4158-4d19-b89a-0d54d03e6907", "e50394ba-3022-4e20-b8de-3334a6e2585c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c48cd22-37ad-4f39-b474-2f7dfed53f0d", "279f07fd-2a9a-4eec-b626-afd3b8480de2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c48cd22-37ad-4f39-b474-2f7dfed53f0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70aab4a6-4158-4d19-b89a-0d54d03e6907");
        }
    }
}
