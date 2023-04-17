using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class EditCatgoryID02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Id",
                table: "AppAD_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Id",
                table: "AppAL_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg01_AppCategory_Id",
                table: "AppCS_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg02_AppCategory_Id",
                table: "AppCS_Seg02");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg03_AppCategory_Id",
                table: "AppCS_Seg03");

            migrationBuilder.DropForeignKey(
                name: "FK_AppDS_Seg01_AppCategory_Id",
                table: "AppDS_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppMT_Seg01_AppCategory_Id",
                table: "AppMT_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppPK_Seg01_AppCategory_Id",
                table: "AppPK_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRC_Seg01_AppCategory_Id",
                table: "AppRC_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg02_AppCategory_Id",
                table: "AppRD_Seg02");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg03_AppCategory_Id",
                table: "AppRD_Seg03");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg04_AppCategory_Id",
                table: "AppRD_Seg04");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTC_Seg01_AppCategory_Id",
                table: "AppTC_Seg01");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg04",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg03",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg02",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppPK_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppMT_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppDS_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg03",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg02",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAL_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_AppTC_Seg01_Category_ID",
                table: "AppTC_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg04_Category_ID",
                table: "AppRD_Seg04",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg03_Category_ID",
                table: "AppRD_Seg03",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRD_Seg02_Category_ID",
                table: "AppRD_Seg02",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppRC_Seg01_Category_ID",
                table: "AppRC_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppPK_Seg01_Category_ID",
                table: "AppPK_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppMT_Seg01_Category_ID",
                table: "AppMT_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppDS_Seg01_Category_ID",
                table: "AppDS_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg03_Category_ID",
                table: "AppCS_Seg03",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg02_Category_ID",
                table: "AppCS_Seg02",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppCS_Seg01_Category_ID",
                table: "AppCS_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppAL_Seg01_Category_ID",
                table: "AppAL_Seg01",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AppAD_Seg01_Category_ID",
                table: "AppAD_Seg01",
                column: "Category_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Category_ID",
                table: "AppAD_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Category_ID",
                table: "AppAL_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg01_AppCategory_Category_ID",
                table: "AppCS_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg02_AppCategory_Category_ID",
                table: "AppCS_Seg02",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg03_AppCategory_Category_ID",
                table: "AppCS_Seg03",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppDS_Seg01_AppCategory_Category_ID",
                table: "AppDS_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppMT_Seg01_AppCategory_Category_ID",
                table: "AppMT_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPK_Seg01_AppCategory_Category_ID",
                table: "AppPK_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRC_Seg01_AppCategory_Category_ID",
                table: "AppRC_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg02_AppCategory_Category_ID",
                table: "AppRD_Seg02",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg03_AppCategory_Category_ID",
                table: "AppRD_Seg03",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg04_AppCategory_Category_ID",
                table: "AppRD_Seg04",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTC_Seg01_AppCategory_Category_ID",
                table: "AppTC_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Category_ID",
                table: "AppAD_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Category_ID",
                table: "AppAL_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg01_AppCategory_Category_ID",
                table: "AppCS_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg02_AppCategory_Category_ID",
                table: "AppCS_Seg02");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCS_Seg03_AppCategory_Category_ID",
                table: "AppCS_Seg03");

            migrationBuilder.DropForeignKey(
                name: "FK_AppDS_Seg01_AppCategory_Category_ID",
                table: "AppDS_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppMT_Seg01_AppCategory_Category_ID",
                table: "AppMT_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppPK_Seg01_AppCategory_Category_ID",
                table: "AppPK_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRC_Seg01_AppCategory_Category_ID",
                table: "AppRC_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg02_AppCategory_Category_ID",
                table: "AppRD_Seg02");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg03_AppCategory_Category_ID",
                table: "AppRD_Seg03");

            migrationBuilder.DropForeignKey(
                name: "FK_AppRD_Seg04_AppCategory_Category_ID",
                table: "AppRD_Seg04");

            migrationBuilder.DropForeignKey(
                name: "FK_AppTC_Seg01_AppCategory_Category_ID",
                table: "AppTC_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppTC_Seg01_Category_ID",
                table: "AppTC_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg04_Category_ID",
                table: "AppRD_Seg04");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg03_Category_ID",
                table: "AppRD_Seg03");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg02_Category_ID",
                table: "AppRD_Seg02");

            migrationBuilder.DropIndex(
                name: "IX_AppRC_Seg01_Category_ID",
                table: "AppRC_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppPK_Seg01_Category_ID",
                table: "AppPK_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppMT_Seg01_Category_ID",
                table: "AppMT_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppDS_Seg01_Category_ID",
                table: "AppDS_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg03_Category_ID",
                table: "AppCS_Seg03");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg02_Category_ID",
                table: "AppCS_Seg02");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg01_Category_ID",
                table: "AppCS_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppAL_Seg01_Category_ID",
                table: "AppAL_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppAD_Seg01_Category_ID",
                table: "AppAD_Seg01");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg04",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppPK_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppMT_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAL_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Id",
                table: "AppAD_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Id",
                table: "AppAL_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg01_AppCategory_Id",
                table: "AppCS_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg02_AppCategory_Id",
                table: "AppCS_Seg02",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg03_AppCategory_Id",
                table: "AppCS_Seg03",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppDS_Seg01_AppCategory_Id",
                table: "AppDS_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppMT_Seg01_AppCategory_Id",
                table: "AppMT_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPK_Seg01_AppCategory_Id",
                table: "AppPK_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRC_Seg01_AppCategory_Id",
                table: "AppRC_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg02_AppCategory_Id",
                table: "AppRD_Seg02",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg03_AppCategory_Id",
                table: "AppRD_Seg03",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg04_AppCategory_Id",
                table: "AppRD_Seg04",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTC_Seg01_AppCategory_Id",
                table: "AppTC_Seg01",
                column: "Id",
                principalTable: "AppCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
