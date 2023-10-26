using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_table_chi_nhanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ghi_chu1",
                table: "chi_nhanhs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ghi_chu1",
                table: "chi_nhanhs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
