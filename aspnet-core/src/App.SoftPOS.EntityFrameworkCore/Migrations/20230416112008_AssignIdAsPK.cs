using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class AssignIdAsPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Category_ID",
                table: "AppAD_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Category_ID",
                table: "AppAL_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Terminal_ID",
                table: "AppCategory");

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
                name: "FK_AppRD_Seg01_AppCategory_Category_ID",
                table: "AppRD_Seg01");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTC_Seg01",
                table: "AppTC_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppTC_Seg01_Category_ID",
                table: "AppTC_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg04",
                table: "AppRD_Seg04");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg04_Category_ID",
                table: "AppRD_Seg04");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg03",
                table: "AppRD_Seg03");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg03_Category_ID",
                table: "AppRD_Seg03");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg02",
                table: "AppRD_Seg02");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg02_Category_ID",
                table: "AppRD_Seg02");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg01",
                table: "AppRD_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppRD_Seg01_Category_ID",
                table: "AppRD_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRC_Seg01",
                table: "AppRC_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppRC_Seg01_Category_ID",
                table: "AppRC_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPosTerminal",
                table: "AppPosTerminal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPK_Seg01",
                table: "AppPK_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppPK_Seg01_Category_ID",
                table: "AppPK_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppMT_Seg01",
                table: "AppMT_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppMT_Seg01_Category_ID",
                table: "AppMT_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppDS_Seg01",
                table: "AppDS_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppDS_Seg01_Category_ID",
                table: "AppDS_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg03",
                table: "AppCS_Seg03");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg03_Category_ID",
                table: "AppCS_Seg03");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg02",
                table: "AppCS_Seg02");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg02_Category_ID",
                table: "AppCS_Seg02");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg01",
                table: "AppCS_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppCS_Seg01_Category_ID",
                table: "AppCS_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory");

            migrationBuilder.DropIndex(
                name: "IX_AppCategory_Terminal_ID",
                table: "AppCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAL_Seg01",
                table: "AppAL_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppAL_Seg01_Category_ID",
                table: "AppAL_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAD_Seg01",
                table: "AppAD_Seg01");

            migrationBuilder.DropIndex(
                name: "IX_AppAD_Seg01_Category_ID",
                table: "AppAD_Seg01");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppTC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRD_Seg04",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg04",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg04",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRD_Seg03",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRD_Seg02",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRC_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppPosTerminal",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Terminal_ID",
                table: "AppPosTerminal",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppPK_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppPK_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppPK_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppMT_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppMT_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppMT_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppDS_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppCS_Seg03",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg03",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppCS_Seg02",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppCS_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg01",
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppCategory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppAL_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAL_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppAL_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppAD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppAD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppAD_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTC_Seg01",
                table: "AppTC_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg04",
                table: "AppRD_Seg04",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg03",
                table: "AppRD_Seg03",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg02",
                table: "AppRD_Seg02",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg01",
                table: "AppRD_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRC_Seg01",
                table: "AppRC_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPosTerminal",
                table: "AppPosTerminal",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPK_Seg01",
                table: "AppPK_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppMT_Seg01",
                table: "AppMT_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppDS_Seg01",
                table: "AppDS_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg03",
                table: "AppCS_Seg03",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg02",
                table: "AppCS_Seg02",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg01",
                table: "AppCS_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAL_Seg01",
                table: "AppAL_Seg01",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAD_Seg01",
                table: "AppAD_Seg01",
                column: "Id");

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
                name: "FK_AppCategory_AppPosTerminal_Id",
                table: "AppCategory",
                column: "Id",
                principalTable: "AppPosTerminal",
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
                name: "FK_AppRD_Seg01_AppCategory_Id",
                table: "AppRD_Seg01",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAD_Seg01_AppCategory_Id",
                table: "AppAD_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Id",
                table: "AppAL_Seg01");

            migrationBuilder.DropForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Id",
                table: "AppCategory");

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
                name: "FK_AppRD_Seg01_AppCategory_Id",
                table: "AppRD_Seg01");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTC_Seg01",
                table: "AppTC_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg04",
                table: "AppRD_Seg04");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg03",
                table: "AppRD_Seg03");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg02",
                table: "AppRD_Seg02");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRD_Seg01",
                table: "AppRD_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRC_Seg01",
                table: "AppRC_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPosTerminal",
                table: "AppPosTerminal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppPK_Seg01",
                table: "AppPK_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppMT_Seg01",
                table: "AppMT_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppDS_Seg01",
                table: "AppDS_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg03",
                table: "AppCS_Seg03");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg02",
                table: "AppCS_Seg02");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCS_Seg01",
                table: "AppCS_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAL_Seg01",
                table: "AppAL_Seg01");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAD_Seg01",
                table: "AppAD_Seg01");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppTC_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppTC_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg04",
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
                name: "Id",
                table: "AppRD_Seg04",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg03",
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
                name: "Id",
                table: "AppRD_Seg03",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg02",
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
                name: "Id",
                table: "AppRD_Seg02",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppRD_Seg01",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppRD_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppRC_Seg01",
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
                name: "Id",
                table: "AppRC_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Terminal_ID",
                table: "AppPosTerminal",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppPosTerminal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppPK_Seg01",
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
                name: "Id",
                table: "AppPK_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppMT_Seg01",
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
                name: "Id",
                table: "AppMT_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppDS_Seg01",
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
                name: "Id",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg03",
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
                name: "Id",
                table: "AppCS_Seg03",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg02",
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
                name: "Id",
                table: "AppCS_Seg02",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppCS_Seg01",
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
                name: "Id",
                table: "AppCS_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Terminal_ID",
                table: "AppCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category_ID",
                table: "AppCategory",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppAL_Seg01",
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
                name: "Id",
                table: "AppAL_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Segment_ID",
                table: "AppAD_Seg01",
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppAD_Seg01",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTC_Seg01",
                table: "AppTC_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg04",
                table: "AppRD_Seg04",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg03",
                table: "AppRD_Seg03",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg02",
                table: "AppRD_Seg02",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRD_Seg01",
                table: "AppRD_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRC_Seg01",
                table: "AppRC_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPosTerminal",
                table: "AppPosTerminal",
                column: "Terminal_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppPK_Seg01",
                table: "AppPK_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppMT_Seg01",
                table: "AppMT_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppDS_Seg01",
                table: "AppDS_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg03",
                table: "AppCS_Seg03",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg02",
                table: "AppCS_Seg02",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCS_Seg01",
                table: "AppCS_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppCategory",
                table: "AppCategory",
                column: "Category_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAL_Seg01",
                table: "AppAL_Seg01",
                column: "Segment_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAD_Seg01",
                table: "AppAD_Seg01",
                column: "Segment_ID");

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
                name: "IX_AppRD_Seg01_Category_ID",
                table: "AppRD_Seg01",
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
                name: "IX_AppCategory_Terminal_ID",
                table: "AppCategory",
                column: "Terminal_ID");

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
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppAL_Seg01_AppCategory_Category_ID",
                table: "AppAL_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCategory_AppPosTerminal_Terminal_ID",
                table: "AppCategory",
                column: "Terminal_ID",
                principalTable: "AppPosTerminal",
                principalColumn: "Terminal_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg01_AppCategory_Category_ID",
                table: "AppCS_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg02_AppCategory_Category_ID",
                table: "AppCS_Seg02",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppCS_Seg03_AppCategory_Category_ID",
                table: "AppCS_Seg03",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppDS_Seg01_AppCategory_Category_ID",
                table: "AppDS_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppMT_Seg01_AppCategory_Category_ID",
                table: "AppMT_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPK_Seg01_AppCategory_Category_ID",
                table: "AppPK_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRC_Seg01_AppCategory_Category_ID",
                table: "AppRC_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg01_AppCategory_Category_ID",
                table: "AppRD_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg02_AppCategory_Category_ID",
                table: "AppRD_Seg02",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg03_AppCategory_Category_ID",
                table: "AppRD_Seg03",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppRD_Seg04_AppCategory_Category_ID",
                table: "AppRD_Seg04",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppTC_Seg01_AppCategory_Category_ID",
                table: "AppTC_Seg01",
                column: "Category_ID",
                principalTable: "AppCategory",
                principalColumn: "Category_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
