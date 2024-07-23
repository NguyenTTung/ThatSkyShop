using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThatSky.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class AddTinhTrangToNGUOI_DUNG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "TinhTrang",
                table: "db_NGUOI_DUNG",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "db_NGUOI_DUNG");
        }
    }
}
