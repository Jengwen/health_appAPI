using Microsoft.EntityFrameworkCore.Migrations;

namespace health_app2.Migrations
{
    public partial class addListUnits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Units",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LockoutEnabled", "PasswordHash", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { "e7a61a99-77e3-43bc-8343-2a8a50fe9ac9", true, false, "AQAAAAEAACcQAAAAEGA9sTqmX3S/pmjm3xq2QAoquD0DQRPWcMyafgkpxMQIm2xS8h9ELqkPB5HEdqcMjQ==", false, false });

            migrationBuilder.CreateIndex(
                name: "IX_Units_UnitId",
                table: "Units",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_Units_UnitId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_UnitId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Units");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LockoutEnabled", "PasswordHash", "PhoneNumberConfirmed", "TwoFactorEnabled" },
                values: new object[] { "80ec44c8-ced9-4dbb-a0e7-b5aaf87e3fda", (short)1, (short)0, "AQAAAAEAACcQAAAAEAanVigLA6ACkXhRkBbOqkRlg2F/ik+1p/IjwHa++Mg2UxMEQFutBDkxdfWMVFUjHg==", (short)0, (short)0 });
        }
    }
}
