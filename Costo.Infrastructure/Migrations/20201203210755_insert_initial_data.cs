using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Costo.Infrastructure.Migrations
{
    public partial class insert_initial_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TransactionCategories",
                columns: new[] { "Id", "CreateDate", "Description", "Icon", "Name", "TransactionCategoryId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("7ca35ce5-0c4d-44a4-9ca3-a9f376c99819"), new DateTime(2020, 12, 3, 22, 7, 54, 578, DateTimeKind.Local).AddTicks(7676), "...", 2, "Wypłata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41d455d5-ff27-41c8-b363-c18039ee52b3"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7615), "...", 2, "Przychód", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5641d3b-9292-4ae8-9187-b31f65f62306"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7650), "...", 2, "Wydatek", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a065fb57-5309-4d99-977c-3f079a99e320"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7656), "...", 2, "Zakupy spożywcze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7b81403-8f2d-4eff-a117-eb32da0150b2"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7660), "...", 2, "Transport", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a287f7d8-fc77-4f95-bead-c0b29ea8860c"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7663), "...", 2, "Zdrowie", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecfe2024-ff94-498e-bac8-916f5332880e"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7667), "...", 2, "Rozrywka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47dfccdd-157b-448f-8d6c-f71fbdb1861e"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7670), "...", 2, "Dom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ac906a0-83c4-47ce-b45d-9738b57a4af4"), new DateTime(2020, 12, 3, 22, 7, 54, 583, DateTimeKind.Local).AddTicks(7674), "...", 2, "Restauracje", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("41d455d5-ff27-41c8-b363-c18039ee52b3"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("47dfccdd-157b-448f-8d6c-f71fbdb1861e"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ca35ce5-0c4d-44a4-9ca3-a9f376c99819"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("9ac906a0-83c4-47ce-b45d-9738b57a4af4"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a065fb57-5309-4d99-977c-3f079a99e320"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a287f7d8-fc77-4f95-bead-c0b29ea8860c"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7b81403-8f2d-4eff-a117-eb32da0150b2"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5641d3b-9292-4ae8-9187-b31f65f62306"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("ecfe2024-ff94-498e-bac8-916f5332880e"));
        }
    }
}
