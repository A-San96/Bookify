using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookify.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_Permission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_permissions_role_role_id",
                table: "permissions");

            migrationBuilder.DropIndex(
                name: "ix_permissions_role_id",
                table: "permissions");

            migrationBuilder.DropColumn(
                name: "role_id",
                table: "permissions");

            migrationBuilder.AddColumn<int>(
                name: "permission_id1",
                table: "role_permissions",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "role_id1",
                table: "role_permissions",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "role_permissions",
                keyColumns: new[] { "permission_id", "role_id" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "permission_id1", "role_id1" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "ix_role_permissions_permission_id",
                table: "role_permissions",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "ix_role_permissions_permission_id1",
                table: "role_permissions",
                column: "permission_id1");

            migrationBuilder.CreateIndex(
                name: "ix_role_permissions_role_id1",
                table: "role_permissions",
                column: "role_id1");

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_permissions_permission_id",
                table: "role_permissions",
                column: "permission_id",
                principalTable: "permissions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_permissions_permission_id1",
                table: "role_permissions",
                column: "permission_id1",
                principalTable: "permissions",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_roles_role_id",
                table: "role_permissions",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_role_permissions_roles_role_id1",
                table: "role_permissions",
                column: "role_id1",
                principalTable: "roles",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_permissions_permission_id",
                table: "role_permissions");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_permissions_permission_id1",
                table: "role_permissions");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_roles_role_id",
                table: "role_permissions");

            migrationBuilder.DropForeignKey(
                name: "fk_role_permissions_roles_role_id1",
                table: "role_permissions");

            migrationBuilder.DropIndex(
                name: "ix_role_permissions_permission_id",
                table: "role_permissions");

            migrationBuilder.DropIndex(
                name: "ix_role_permissions_permission_id1",
                table: "role_permissions");

            migrationBuilder.DropIndex(
                name: "ix_role_permissions_role_id1",
                table: "role_permissions");

            migrationBuilder.DropColumn(
                name: "permission_id1",
                table: "role_permissions");

            migrationBuilder.DropColumn(
                name: "role_id1",
                table: "role_permissions");

            migrationBuilder.AddColumn<int>(
                name: "role_id",
                table: "permissions",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "permissions",
                keyColumn: "id",
                keyValue: 1,
                column: "role_id",
                value: null);

            migrationBuilder.CreateIndex(
                name: "ix_permissions_role_id",
                table: "permissions",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "fk_permissions_role_role_id",
                table: "permissions",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id");
        }
    }
}
