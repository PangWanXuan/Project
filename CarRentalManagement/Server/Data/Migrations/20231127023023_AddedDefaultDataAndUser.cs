using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Vehicles",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Models",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Models",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Makes",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Customers",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Colours",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Colours",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Bookings",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2b400342-7bbb-4d33-967b-99d2c98b984e", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPJsBDnQMChlPUzXMNox8GS2I1AIZhHNt1VDVAgZEILLfLcpGsHUIUXT0qbpOjeAOg==", null, false, "5460e7aa-7d3d-4863-bc3c-eaf1f03beed0", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(31), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(38), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1083), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1088), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1090), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ID", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1727), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1733), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1737), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 11, 27, 10, 30, 23, 234, DateTimeKind.Local).AddTicks(1741), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Vehicles",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Models",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Models",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Makes",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Customers",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Colours",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colours",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Bookings",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "Updated");
        }
    }
}
