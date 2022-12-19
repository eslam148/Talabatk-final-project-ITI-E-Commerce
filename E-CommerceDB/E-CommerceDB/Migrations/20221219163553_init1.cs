using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_CommerceDB.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "213b92ce-b82e-4f1f-8edf-cf8d8344f019");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d283782-09dc-4d9c-b339-1456c3dfc67b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6de12ed4-e5d3-461a-a9cd-3bee0d98d961");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a33a68e-54b6-40fa-b937-8c7c75ebff83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b544ba2a-17c2-4fd5-94a6-f399498979da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b79afd8b-b868-4a4a-968f-c99e17c86f34");

            migrationBuilder.RenameColumn(
                name: "totalrating",
                table: "Products",
                newName: "totalRating");

            migrationBuilder.RenameColumn(
                name: "ratingcount",
                table: "Products",
                newName: "ratingCount");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ffdfc84-9829-4501-bbf5-3012cd61aaa9", "ba38be89-8aee-40b7-8036-ef396da20b47", "Admin", null },
                    { "c9becaa0-b0bb-4f09-9fcd-6b1b296e7110", "f84f4bbb-173f-4a54-8dd7-2b9138387f29", "Buyer", null },
                    { "cac6db3a-873d-4e79-a43a-f95add0b9c65", "f2f845e1-e643-4dc1-9e58-a6cf9679d406", "Seller", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Email", "EmailConfirmed", "First_Name", "IsDeleted", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilieImage", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName", "modified_at" },
                values: new object[,]
                {
                    { "1f032a57-8ed5-4abf-ab28-34996f338b01", 0, "f84b2acd-416f-498d-82bc-9d94bb64c2d5", new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2991), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "afc1868e-9902-4781-9308-4fe90bf97920", false, null, new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2992) },
                    { "a906cb64-3ef7-4b7e-a517-99f41f5542dd", 0, "034a59f9-446a-4bba-ba10-532837c194f5", new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3022), "Eslam@ss.com", false, "Ahmed", false, "Amir", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "fc17692e-fe7c-46ca-a9d9-6230506153d0", false, null, new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3023) },
                    { "d176cbea-dafb-43b0-aab8-bb2240135913", 0, "f45d846c-0b44-4f6b-b83d-9d12fcbc4f6a", new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2944), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "335cfde3-cbdf-4db4-9aff-85a39846a439", false, "Admin", new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2945) }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2787), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2853), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3115), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3073), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3260), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2921), new DateTime(2022, 12, 19, 18, 35, 50, 755, DateTimeKind.Local).AddTicks(2923) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ffdfc84-9829-4501-bbf5-3012cd61aaa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9becaa0-b0bb-4f09-9fcd-6b1b296e7110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac6db3a-873d-4e79-a43a-f95add0b9c65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f032a57-8ed5-4abf-ab28-34996f338b01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a906cb64-3ef7-4b7e-a517-99f41f5542dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d176cbea-dafb-43b0-aab8-bb2240135913");

            migrationBuilder.RenameColumn(
                name: "totalRating",
                table: "Products",
                newName: "totalrating");

            migrationBuilder.RenameColumn(
                name: "ratingCount",
                table: "Products",
                newName: "ratingcount");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "213b92ce-b82e-4f1f-8edf-cf8d8344f019", "74ece556-b73d-44c9-8511-2c31119ae0f3", "Admin", null },
                    { "4d283782-09dc-4d9c-b339-1456c3dfc67b", "6ef22079-bba5-4a67-b1ca-9a1ee38fba2f", "Seller", null },
                    { "6de12ed4-e5d3-461a-a9cd-3bee0d98d961", "e5c2ffd9-5277-47df-92b7-aca2974aaa97", "Buyer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created_at", "Email", "EmailConfirmed", "First_Name", "IsDeleted", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilieImage", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName", "modified_at" },
                values: new object[,]
                {
                    { "0a33a68e-54b6-40fa-b937-8c7c75ebff83", 0, "4803de9a-b566-4000-b087-8c7758b25320", new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3140), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "b4a7fdf7-23cd-492c-99fc-3df980d67f51", false, null, new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3142) },
                    { "b544ba2a-17c2-4fd5-94a6-f399498979da", 0, "715c0dce-84ed-4296-8336-b43daaf9648f", new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3219), "Eslam@ss.com", false, "Ahmed", false, "Amir", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "48a3a9b1-5d19-4009-b057-81e164e309bf", false, null, new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3221) },
                    { "b79afd8b-b868-4a4a-968f-c99e17c86f34", 0, "894cb813-637d-4b56-8118-6329f418766a", new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3049), "Eslam@ss.com", false, "Mohamed", false, "Ahmed", false, null, null, null, null, null, false, "https://www.w3schools.com/w3images/avatar3.png", null, "3f287fd9-0e6b-4aa4-a73d-b463fe0794c0", false, "Admin", new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3051) }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3609), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2914), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2958), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "modified_at" },
                values: new object[] { new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 12, 19, 18, 29, 26, 957, DateTimeKind.Local).AddTicks(2998) });
        }
    }
}
