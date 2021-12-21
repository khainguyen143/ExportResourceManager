using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExportResourceManager.Migrations
{
    public partial class add_Edit_IntergratedResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "139321be-1d0c-4a5d-aa2f-c3ff02078666");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "6afdd591-893c-476f-8a54-a78ca8def929");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "96ec9a47-4dc6-491c-8278-12a7451520ba");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "98f00f47-476e-4285-a420-719091eab6da");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "d29bdbe3-60f7-49f0-9294-6b1db97f5907");

            migrationBuilder.CreateTable(
                name: "EditIntergratedResources",
                columns: table => new
                {
                    ParentIntergratedResourcesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubIntergratedResourcesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditIntergratedResources", x => new { x.ParentIntergratedResourcesId, x.SubIntergratedResourcesId });
                    table.ForeignKey(
                        name: "FK_EditIntergratedResources_IntergratedResources_ParentIntergratedResourcesId",
                        column: x => x.ParentIntergratedResourcesId,
                        principalTable: "IntergratedResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditIntergratedResources_IntergratedResources_SubIntergratedResourcesId",
                        column: x => x.SubIntergratedResourcesId,
                        principalTable: "IntergratedResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4d01b5d9-6458-4258-a03d-7852ac6c43a9",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4d01b5d9-6458-4258-a03d-7852ac6c43b8",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DeletedByUserId", "DeletedDate", "IsDeleted", "Permission", "RoleId", "UpdatedByUserId", "UpdatedDate" },
                values: new object[,]
                {
                    { "ead9ee17-c755-4512-bf39-4d82b16a9b8b", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(7030), null, null, false, 0, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "1a5db82d-3c7e-4057-9a48-261d0c5f0670", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(7690), null, null, false, 100000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "eebc7334-fa03-4081-ac06-871c1f0b8438", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(7697), null, null, false, 200000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "6cc8b0fa-f95e-4788-8ed3-474915ff13ee", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(7700), null, null, false, 300000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "21a3a9bf-c7c3-414d-acf9-1a47fa274320", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(7712), null, null, false, 0, "4d01b5d9-6458-4258-a03d-7852ac6c43b8", null, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "92ad4f43-4be7-4fb8-909f-ced532c58461",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 18, 9, 0, 277, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d01b5d9-6458-4258-a03d-7852ac6c43a9", "92ad4f43-4be7-4fb8-909f-ced532c58461" },
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 18, 9, 0, 278, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.CreateIndex(
                name: "IX_EditIntergratedResources_SubIntergratedResourcesId",
                table: "EditIntergratedResources",
                column: "SubIntergratedResourcesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditIntergratedResources");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "1a5db82d-3c7e-4057-9a48-261d0c5f0670");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "21a3a9bf-c7c3-414d-acf9-1a47fa274320");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "6cc8b0fa-f95e-4788-8ed3-474915ff13ee");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "ead9ee17-c755-4512-bf39-4d82b16a9b8b");

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "Id",
                keyValue: "eebc7334-fa03-4081-ac06-871c1f0b8438");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4d01b5d9-6458-4258-a03d-7852ac6c43a9",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4d01b5d9-6458-4258-a03d-7852ac6c43b8",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DeletedByUserId", "DeletedDate", "IsDeleted", "Permission", "RoleId", "UpdatedByUserId", "UpdatedDate" },
                values: new object[,]
                {
                    { "6afdd591-893c-476f-8a54-a78ca8def929", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(4381), null, null, false, 0, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "139321be-1d0c-4a5d-aa2f-c3ff02078666", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(5045), null, null, false, 100000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "96ec9a47-4dc6-491c-8278-12a7451520ba", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(5052), null, null, false, 200000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "d29bdbe3-60f7-49f0-9294-6b1db97f5907", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(5055), null, null, false, 300000000, "4d01b5d9-6458-4258-a03d-7852ac6c43a9", null, null },
                    { "98f00f47-476e-4285-a420-719091eab6da", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(5058), null, null, false, 0, "4d01b5d9-6458-4258-a03d-7852ac6c43b8", null, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "92ad4f43-4be7-4fb8-909f-ced532c58461",
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 15, 11, 29, 368, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d01b5d9-6458-4258-a03d-7852ac6c43a9", "92ad4f43-4be7-4fb8-909f-ced532c58461" },
                column: "CreatedDate",
                value: new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(2990));
        }
    }
}
