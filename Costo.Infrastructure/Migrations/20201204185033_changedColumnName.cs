using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Costo.Infrastructure.Migrations
{
    public partial class changedColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
