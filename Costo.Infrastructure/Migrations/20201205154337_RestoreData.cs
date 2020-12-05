using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Costo.Infrastructure.Migrations
{
    public partial class RestoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("22d028f4-57fd-44ad-b8ee-8c75bbd47e31"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("5f032030-a767-4666-a5ff-09828b106ee3"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("86c31316-975b-42af-a348-289b47381e65"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("961ce142-c72c-4812-9536-e7da1e2501b4"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2ed6de7-be3f-4982-9072-3c6f908e3ab2"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8f93cc5-79bb-4150-b562-bd20cab17f52"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("d507dd46-18b9-4579-ab0e-aa33c74cf5e0"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("d76e95dd-9d10-45fc-b90b-b84877e3cdbe"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("decda3d0-7055-43c9-b55f-6b19c77c78ca"));

            migrationBuilder.InsertData(
                table: "TransactionCategories",
                columns: new[] { "Id", "Color", "CreateDate", "Description", "Icon", "Name", "TransactionCategoryId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("66b251e2-5e24-4651-98ba-56e86487eb27"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 737, DateTimeKind.Local).AddTicks(9944), "...", "Money", "Wypłata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65176457-697f-4d37-91d7-81737f355ad7"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2888), "...", "Money", "Przychód", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c36e5b1c-54ee-40ad-8134-2557919ab06a"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2920), "...", "Money", "Wydatek", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e58260c4-cc20-43ee-af5a-d912280d02c1"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2925), "...", "Money", "Zakupy spożywcze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("59a4b180-eff9-4fbd-93f2-01f6c320fdf0"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2929), "...", "Money", "Transport", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("371a865a-b34f-44d0-b121-3529142fe91c"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2933), "...", "Money", "Zdrowie", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abe643b0-b344-412c-898a-3c0ff586c433"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2936), "...", "Money", "Rozrywka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb9fa1d3-408d-45e0-9632-d5491df0e7ed"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2940), "...", "Money", "Dom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5999e27f-1e51-4b49-a842-4acd5d10c3f4"), "Blue", new DateTime(2020, 12, 5, 16, 43, 36, 741, DateTimeKind.Local).AddTicks(2953), "...", "Money", "Restauracje", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("371a865a-b34f-44d0-b121-3529142fe91c"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("5999e27f-1e51-4b49-a842-4acd5d10c3f4"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("59a4b180-eff9-4fbd-93f2-01f6c320fdf0"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("65176457-697f-4d37-91d7-81737f355ad7"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("66b251e2-5e24-4651-98ba-56e86487eb27"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("abe643b0-b344-412c-898a-3c0ff586c433"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("c36e5b1c-54ee-40ad-8134-2557919ab06a"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("e58260c4-cc20-43ee-af5a-d912280d02c1"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("fb9fa1d3-408d-45e0-9632-d5491df0e7ed"));

            migrationBuilder.InsertData(
                table: "TransactionCategories",
                columns: new[] { "Id", "Color", "CreateDate", "Description", "Icon", "Name", "TransactionCategoryId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("961ce142-c72c-4812-9536-e7da1e2501b4"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 553, DateTimeKind.Local).AddTicks(4870), "...", "Money", "Wypłata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d507dd46-18b9-4579-ab0e-aa33c74cf5e0"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1438), "...", "Money", "Przychód", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f032030-a767-4666-a5ff-09828b106ee3"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1492), "...", "Money", "Wydatek", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d76e95dd-9d10-45fc-b90b-b84877e3cdbe"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1498), "...", "Money", "Zakupy spożywcze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2ed6de7-be3f-4982-9072-3c6f908e3ab2"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1502), "...", "Money", "Transport", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86c31316-975b-42af-a348-289b47381e65"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1506), "...", "Money", "Zdrowie", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("decda3d0-7055-43c9-b55f-6b19c77c78ca"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1510), "...", "Money", "Rozrywka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22d028f4-57fd-44ad-b8ee-8c75bbd47e31"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1514), "...", "Money", "Dom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8f93cc5-79bb-4150-b562-bd20cab17f52"), "Blue", new DateTime(2020, 12, 5, 16, 30, 0, 557, DateTimeKind.Local).AddTicks(1529), "...", "Money", "Restauracje", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
