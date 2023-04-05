using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.SoftPOS.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeReqToMTI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MTI_Code",
                table: "AppMTIs",
                newName: "MTI_Code_Resp");

            migrationBuilder.AddColumn<string>(
                name: "MTI_Code_Req",
                table: "AppMTIs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Response_Code",
                table: "AppMTIs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MTI_Code_Req",
                table: "AppMTIs");

            migrationBuilder.DropColumn(
                name: "Response_Code",
                table: "AppMTIs");

            migrationBuilder.RenameColumn(
                name: "MTI_Code_Resp",
                table: "AppMTIs",
                newName: "MTI_Code");
        }
    }
}
