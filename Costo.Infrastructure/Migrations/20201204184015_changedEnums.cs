using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Costo.Infrastructure.Migrations
{
    public partial class changedEnums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "TransactionCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AccountType",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "TransactionCategories",
                columns: new[] { "Id", "CreateDate", "Description", "Icon", "Name", "TransactionCategoryId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("5e8bd641-7c28-4023-99ac-990ab3e7fe5e"), new DateTime(2020, 12, 4, 19, 40, 15, 300, DateTimeKind.Local).AddTicks(65), "...", "Money", "Wypłata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8fda30b-e535-4120-ad49-14323f2463f1"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2813), "...", "Money", "Przychód", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a84f0a9f-b271-4d31-a7bd-e0a56176e954"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2847), "...", "Money", "Wydatek", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28ff0e24-606a-4a05-bf60-f4aabda6dab6"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2852), "...", "Money", "Zakupy spożywcze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75b6b4c5-72be-42b7-83df-93a21a3d74fc"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2856), "...", "Money", "Transport", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("741a8a7a-57b1-4226-a8b6-29a0ed39160e"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2859), "...", "Money", "Zdrowie", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ea5a64a-c89a-451a-900f-867b9d34f1cc"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2862), "...", "Money", "Rozrywka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc8c3b63-d9a4-4e59-b83b-6a9181011572"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2866), "...", "Money", "Dom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad97c73f-8841-4574-814d-c05f78e2a9c9"), new DateTime(2020, 12, 4, 19, 40, 15, 303, DateTimeKind.Local).AddTicks(2878), "...", "Money", "Restauracje", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("28ff0e24-606a-4a05-bf60-f4aabda6dab6"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ea5a64a-c89a-451a-900f-867b9d34f1cc"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e8bd641-7c28-4023-99ac-990ab3e7fe5e"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("741a8a7a-57b1-4226-a8b6-29a0ed39160e"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("75b6b4c5-72be-42b7-83df-93a21a3d74fc"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a84f0a9f-b271-4d31-a7bd-e0a56176e954"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad97c73f-8841-4574-814d-c05f78e2a9c9"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("d8fda30b-e535-4120-ad49-14323f2463f1"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("dc8c3b63-d9a4-4e59-b83b-6a9181011572"));

            migrationBuilder.AlterColumn<int>(
                name: "TransactionType",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Icon",
                table: "TransactionCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Icon",
                table: "BankAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountType",
                table: "BankAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
