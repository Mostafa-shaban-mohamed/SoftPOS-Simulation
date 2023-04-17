using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class Edited_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppTC_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppRD_Seg04",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppRD_Seg03",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppRD_Seg02",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppRD_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppRC_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppPK_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppMT_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaxSAFDepth",
                table: "AppDS_Seg01",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppCS_Seg03",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppCS_Seg02",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppCS_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppAL_Seg01",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AppAD_Seg01",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppTC_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRD_Seg04");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRD_Seg03");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRD_Seg02");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRD_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRC_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppPK_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppMT_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppDS_Seg01");

            migrationBuilder.DropColumn(
                name: "MaxSAFDepth",
                table: "AppDS_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppCS_Seg03");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppCS_Seg02");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppCS_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppAL_Seg01");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppAD_Seg01");
        }
    }
}
