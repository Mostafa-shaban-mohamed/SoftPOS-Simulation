using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class EditCatgoryID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Id",
                table: "AppCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg01_AppCategory_Id",
                table: "AppRD_Seg01");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Terminal_ID",
                table: "AppCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg01_Category_ID",
                table: "AppRD_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCategory_Terminal_ID",
                table: "AppCategory",
                column: "Terminal_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Terminal_ID",
                table: "AppCategory",
                column: "Terminal_ID",
                principalTable: "AppPosTerminal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg01_AppCategory_Category_ID",
                table: "AppRD_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Terminal_ID",
                table: "AppCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg01_AppCategory_Category_ID",
                table: "AppRD_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg01_Category_ID",
                table: "AppRD_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppCategory_Terminal_ID",
                table: "AppCategory");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Terminal_ID",
                table: "AppCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Id",
                table: "AppCategory",
                column: "Id",
                principalTable: "AppPosTerminal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg01_AppCategory_Id",
                table: "AppRD_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
