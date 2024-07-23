using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThatSky.Data.Access.Migrations
{
    /// <inheritdoc />
    public partial class AddDiaChiAndSDTAndHoTenToHoaDon : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "DiaChi",
				table: "db_HOA_DON",
				type: "nvarchar(150)",
				maxLength: 150,
				nullable: false);

			migrationBuilder.AddColumn<string>(
				name: "SoDienThoai",
				table: "db_HOA_DON",
				maxLength: 10,
				type: "nvarchar(10)",
				nullable: false);

			migrationBuilder.AddColumn<string>(
				name: "TenND",
				table: "db_HOA_DON",
				type: "nvarchar(50)",
				maxLength: 50,
				nullable: false);

        }

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "DiaChi",
				table: "db_HOA_DON");

			migrationBuilder.DropColumn(
				name: "SoDienThoai",
				table: "db_HOA_DON");
			migrationBuilder.DropColumn(
				name: "TenND",
				table: "db_HOA_DON");

		}
	}
}
