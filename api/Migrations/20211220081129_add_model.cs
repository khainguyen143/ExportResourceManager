using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExportResourceManager.Migrations
{
    public partial class add_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntergratedResources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceFileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditingSoftware = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedByUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntergratedResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IntergratedResources_User_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntergratedResources_User_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntergratedResources_User_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrimordialResources",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceFileId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceType = table.Column<int>(type: "int", nullable: false),
                    IsProvenOrigin = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimordialResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrimordialResources_User_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrimordialResources_User_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrimordialResources_User_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_User_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_User_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_User_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRestriction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Permission = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRestriction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRestriction_User_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRestriction_User_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRestriction_User_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRestriction_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EditResources",
                columns: table => new
                {
                    IntergratedResourcesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrimordialResourcesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<long>(type: "bigint", nullable: false),
                    EndTime = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditResources", x => new { x.IntergratedResourcesId, x.PrimordialResourcesId });
                    table.ForeignKey(
                        name: "FK_EditResources_IntergratedResources_IntergratedResourcesId",
                        column: x => x.IntergratedResourcesId,
                        principalTable: "IntergratedResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditResources_PrimordialResources_PrimordialResourcesId",
                        column: x => x.PrimordialResourcesId,
                        principalTable: "PrimordialResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Permission = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_User_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermission_User_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermission_User_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "UpdatedDate", "UserName" },
                values: new object[] { "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 368, DateTimeKind.Local).AddTicks(9100), null, false, null, "admin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DeletedByUserId", "DeletedDate", "Description", "IsDeleted", "Name", "UpdatedByUserId", "UpdatedDate" },
                values: new object[] { "4d01b5d9-6458-4258-a03d-7852ac6c43a9", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(1906), null, null, null, false, "application_admin", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "DeletedByUserId", "DeletedDate", "Description", "IsDeleted", "Name", "UpdatedByUserId", "UpdatedDate" },
                values: new object[] { "4d01b5d9-6458-4258-a03d-7852ac6c43b8", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(2368), null, null, null, false, "application_user", null, null });

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

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId", "CreatedDate" },
                values: new object[] { "4d01b5d9-6458-4258-a03d-7852ac6c43a9", "92ad4f43-4be7-4fb8-909f-ced532c58461", new DateTime(2021, 12, 20, 15, 11, 29, 370, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.CreateIndex(
                name: "IX_EditResources_PrimordialResourcesId",
                table: "EditResources",
                column: "PrimordialResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_IntergratedResources_CreatedByUserId",
                table: "IntergratedResources",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntergratedResources_DeletedByUserId",
                table: "IntergratedResources",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntergratedResources_UpdatedByUserId",
                table: "IntergratedResources",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimordialResources_CreatedByUserId",
                table: "PrimordialResources",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimordialResources_DeletedByUserId",
                table: "PrimordialResources",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimordialResources_UpdatedByUserId",
                table: "PrimordialResources",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedByUserId",
                table: "Role",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_DeletedByUserId",
                table: "Role",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UpdatedByUserId",
                table: "Role",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_CreatedByUserId",
                table: "RolePermission",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_DeletedByUserId",
                table: "RolePermission",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleId",
                table: "RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_UpdatedByUserId",
                table: "RolePermission",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRestriction_CreatedByUserId",
                table: "UserRestriction",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRestriction_DeletedByUserId",
                table: "UserRestriction",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRestriction_UpdatedByUserId",
                table: "UserRestriction",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRestriction_UserId",
                table: "UserRestriction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditResources");

            migrationBuilder.DropTable(
                name: "RolePermission");

            migrationBuilder.DropTable(
                name: "UserRestriction");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "IntergratedResources");

            migrationBuilder.DropTable(
                name: "PrimordialResources");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
