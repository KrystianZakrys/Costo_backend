using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Costo.Infrastructure.Migrations
{
    public partial class AddedColorToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b843fcc-4eba-4295-81f9-f2b47eb7dc2a"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("255dabe5-61c2-4f48-a247-06a74d843936"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("79f7bf4f-4ad3-4f53-80b5-5ee2726390f6"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("8452bfe8-d937-4584-8c45-d9b792616180"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("a3835d92-6676-477e-8174-b587c87fcfe6"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("b42895a4-315b-4e89-96a0-acd7dda7a7e6"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("b8027ac9-8478-44da-9103-5f04adf057ad"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("e74f5675-0488-445d-8857-75c636154b7f"));

            migrationBuilder.DeleteData(
                table: "TransactionCategories",
                keyColumn: "Id",
                keyValue: new Guid("f66b2a1b-31d3-49c9-ac73-62ca18c03508"));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "TransactionCategories",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Color",
                table: "TransactionCategories");

            migrationBuilder.InsertData(
                table: "TransactionCategories",
                columns: new[] { "Id", "CreateDate", "Description", "Icon", "Name", "TransactionCategoryId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("8452bfe8-d937-4584-8c45-d9b792616180"), new DateTime(2020, 12, 4, 19, 50, 32, 704, DateTimeKind.Local).AddTicks(3776), "...", "Money", "Wypłata", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b42895a4-315b-4e89-96a0-acd7dda7a7e6"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7462), "...", "Money", "Przychód", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8027ac9-8478-44da-9103-5f04adf057ad"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7510), "...", "Money", "Wydatek", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b843fcc-4eba-4295-81f9-f2b47eb7dc2a"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7515), "...", "Money", "Zakupy spożywcze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79f7bf4f-4ad3-4f53-80b5-5ee2726390f6"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7531), "...", "Money", "Transport", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e74f5675-0488-445d-8857-75c636154b7f"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7535), "...", "Money", "Zdrowie", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3835d92-6676-477e-8174-b587c87fcfe6"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7538), "...", "Money", "Rozrywka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("255dabe5-61c2-4f48-a247-06a74d843936"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7542), "...", "Money", "Dom", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f66b2a1b-31d3-49c9-ac73-62ca18c03508"), new DateTime(2020, 12, 4, 19, 50, 32, 707, DateTimeKind.Local).AddTicks(7545), "...", "Money", "Restauracje", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
