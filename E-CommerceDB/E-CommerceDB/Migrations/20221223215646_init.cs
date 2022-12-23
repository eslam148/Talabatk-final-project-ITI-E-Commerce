using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_CommerceDB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0510745e-3e5a-4c00-aaf3-cb04996c98e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35d02365-dd5c-448a-b0a1-f31b16ebc1ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "908d1b75-5c31-40e0-859a-1a121140937e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58ba496c-c2e8-4088-a6d3-c213ed01a2ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "967581be-db51-4625-bbfd-0292a6556cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0815894-1748-4957-8ed7-d1e3d6c46994");

            migrationBuilder.DropColumn(
                name: "address_line2",
                table: "User_Address");

            migrationBuilder.DropColumn(
                name: "telephone",
                table: "User_Address");

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3104), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7190), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(6959), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7316), new DateTime(2022, 12, 23, 23, 56, 44, 450, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3156), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3183), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 12, 23, 23, 56, 44, 447, DateTimeKind.Local).AddTicks(3201) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "address_line2",
                table: "User_Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "telephone",
                table: "User_Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0510745e-3e5a-4c00-aaf3-cb04996c98e9", "b90d67aa-4f2f-46e8-a302-eae25fff2567", "Seller", null },
                    { "35d02365-dd5c-448a-b0a1-f31b16ebc1ee", "bae13058-f5c6-4de8-9ca3-5bc53277fe6d", "Admin", null },
                    { "908d1b75-5c31-40e0-859a-1a121140937e", "3f9ed1c0-6dbc-4390-b8d7-be176de3abd6", "Buyer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Email", "EmailConfirmed", "First_Name", "IsDeleted", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilieImage", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName", "modified_at" },
                values: new object[,]
                {
                    { "58ba496c-c2e8-4088-a6d3-c213ed01a2ab", 0, "d7c97474-a13d-4bbf-999f-ae095ed46207", new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1977), "Eslam@ss.com", false, "Ahmed", false, "Amir", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "3da82c17-5b3c-4112-8587-a5c78f41ca35", false, null, new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1978) },
                    { "967581be-db51-4625-bbfd-0292a6556cf2", 0, "70a0c54f-a9fa-44fd-9765-ec5810b14433", new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1886), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "544bd976-8c48-4b70-ab81-a5a06c0243c5", false, "Admin", new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1887) },
                    { "e0815894-1748-4957-8ed7-d1e3d6c46994", 0, "70ca3a84-5847-4eb7-a3a2-81ac93cca018", new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1950), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "3c974ee1-1b65-4110-af8c-6b3dd1b01317", false, null, new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1951) }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1625), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1670), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1687), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3210), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3258), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3273), new DateTime(2022, 12, 22, 17, 15, 13, 591, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 12, 22, 17, 15, 13, 589, DateTimeKind.Local).AddTicks(1865) });
        }
    }
}
