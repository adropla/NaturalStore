using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaturalStore.Migrations
{
    public partial class passwordupd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e7c36654-9a22-4575-8082-fd08e62b876e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca316bde-e32a-46a1-aa75-41e69ea331dc", "AQAAAAEAACcQAAAAEFMHOwTHb/lquunG/QSkY/JHMQb/TOl1FN3+nLs53T1EGtYDptIiM1CoKq13emKYUg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 17, 0, 52, 808, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 17, 0, 52, 808, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 17, 0, 52, 808, DateTimeKind.Utc).AddTicks(5709));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "b96a43b1-bc76-44cb-83c5-0c512afeff67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f88e416-e498-4ea6-859d-1271f564851d", "AQAAAAEAACcQAAAAEAgEo/zj4VllCDFJKdok98rJ4Lm2wFEvhRW7KYWOlE3h+pMoWOP6p/VhXHI+sY/pNA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 16, 56, 0, 793, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 16, 56, 0, 792, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 1, 19, 16, 56, 0, 793, DateTimeKind.Utc).AddTicks(1412));
        }
    }
}
