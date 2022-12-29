using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_CommerceDB.Migrations
{
    public partial class initq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Inventory_InventoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Products_InventoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26f3b367-99cc-4339-ad51-14d53f3ebd8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48d31b7c-b1ec-4c9a-9944-2220df67a23b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a82c65-fad7-4ba9-8424-57b32597bb25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e4ca1b-8ee6-4673-a2a0-edd9e13ff7a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40433371-b40b-49ea-b622-a9ae5bea9951");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ebb6a47-0e47-47dc-9e99-b5e9e97c7a4d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "BrandNameAr",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Discount",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandNameAr",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SelledQuantity = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modified_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26f3b367-99cc-4339-ad51-14d53f3ebd8f", "3c88d56a-9f6a-4a78-9455-545bcbe009ca", "Admin", null },
                    { "48d31b7c-b1ec-4c9a-9944-2220df67a23b", "b01096d0-04c5-427d-a258-3cad26f6a72a", "Seller", null },
                    { "d8a82c65-fad7-4ba9-8424-57b32597bb25", "fdf7969c-e3d6-4ad7-8807-32bc07bee35c", "Buyer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Email", "EmailConfirmed", "First_Name", "IsDeleted", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilieImage", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName", "modified_at" },
                values: new object[,]
                {
                    { "29e4ca1b-8ee6-4673-a2a0-edd9e13ff7a4", 0, "f6a995ac-1d20-4e11-8e4e-aeea7006c376", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3222), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "b9e0e8d2-8435-493d-bc06-cd59f0d506ac", false, "Admin", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3223) },
                    { "40433371-b40b-49ea-b622-a9ae5bea9951", 0, "6230ec33-10eb-4c92-9045-35051000625a", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3291), "Eslam@ss.com", false, "Ahmed", false, "Amir", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "bb98bf46-3503-415d-9239-beb0b78ae8bf", false, null, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3292) },
                    { "7ebb6a47-0e47-47dc-9e99-b5e9e97c7a4d", 0, "c9676ff3-67df-40da-8a12-8d681a8a4e9e", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3260), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "d4f9f92c-fdfe-458a-92b2-4694a361efe2", false, null, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3262) }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "IsDeleted", "Name", "created_at", "deleted_at", "modified_at" },
                values: new object[,]
                {
                    { 1, "Electronic Devices", false, "Electronic", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3064), null, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3065) },
                    { 2, "Electronic Devices", false, "Clothes", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3104), null, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3106) },
                    { 3, "Electronic Devices", false, "goods", new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3125), null, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3126) }
                });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "Active", "Description", "Disc_Percent", "IsDeleted", "Name", "created_at", "deleted_at", "modified_at" },
                values: new object[] { 1, true, "gg", 10m, false, "hh", new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7190), null, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Quantity", "SelledQuantity", "created_at", "deleted_at", "modified_at" },
                values: new object[,]
                {
                    { 1, 5, 0, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(6959), null, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(6975) },
                    { 2, 5, 0, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7137), null, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7140) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "BrandName", "CategoryId", "IsDeleted", "created_at", "modified_at" },
                values: new object[] { 1, "Samsung", 1, false, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3156), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "BrandName", "CategoryId", "IsDeleted", "created_at", "modified_at" },
                values: new object[] { 2, "Appile", 1, false, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3183), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "BrandName", "CategoryId", "IsDeleted", "created_at", "modified_at" },
                values: new object[] { 3, "Keriaze", 3, false, new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "InventoryId", "IsDeleted", "Name", "Price", "Progress", "Quantity", "SelledQuantity", "SellerId", "SellyerId", "SubCategories_Id", "created_at", "deleted_at", "discount_Id", "inventory_Id", "modified_at", "ratingCount", "totalRating" },
                values: new object[] { 1, "Samsung Phone", null, false, "Samasung A32", 5000, 0, 0, 0, null, null, 2, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7243), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7245), 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "InventoryId", "IsDeleted", "Name", "Price", "Progress", "Quantity", "SelledQuantity", "SellerId", "SellyerId", "SubCategories_Id", "created_at", "deleted_at", "discount_Id", "inventory_Id", "modified_at", "ratingCount", "totalRating" },
                values: new object[] { 2, "Samsung Phone", null, false, "Samasung A52", 6000, 0, 0, 0, null, null, 2, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7282), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7285), 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "InventoryId", "IsDeleted", "Name", "Price", "Progress", "Quantity", "SelledQuantity", "SellerId", "SellyerId", "SubCategories_Id", "created_at", "deleted_at", "discount_Id", "inventory_Id", "modified_at", "ratingCount", "totalRating" },
                values: new object[] { 3, "Samsung Phone", null, false, "Samasung A72", 7000, 0, 0, 0, null, null, 2, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7318), 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoryId",
                table: "Products",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Inventory_InventoryId",
                table: "Products",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id");
        }
    }
}
