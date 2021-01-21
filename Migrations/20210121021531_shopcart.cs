using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaturalStore.Migrations
{
    public partial class shopcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceItemId = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ShopCardId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartLines_ServiceItems_ServiceItemId",
                        column: x => x.ServiceItemId,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "dc961e86-3351-4b7a-9076-3e07dabeecd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1703cb84-6e9d-4377-8d1a-3071bf3e72d5", "AQAAAAEAACcQAAAAEF59rvPYQIK+e+j6jPyMDATI4rNtjuMc9j2ESuJl06fndY6fGxjb4O7tS+9J0KI3RQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 21, 2, 15, 30, 364, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 21, 2, 15, 30, 363, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 21, 2, 15, 30, 364, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.CreateIndex(
                name: "IX_CartLines_ServiceItemId",
                table: "CartLines",
                column: "ServiceItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLines");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e21e89fc-ac90-4b87-8675-e5363134f712");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c8ff381-b37f-422e-b390-cd49f7cfeea8", "AQAAAAEAACcQAAAAEBXHxjrUZaIY4+1o8Ris9RPBmw6TYk63XKjvg7EDMpyJ2oLsk3fxI/8X59n7buItfg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 20, 11, 50, 41, 455, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 20, 11, 50, 41, 455, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 20, 11, 50, 41, 455, DateTimeKind.Utc).AddTicks(7516));
        }
    }
}
