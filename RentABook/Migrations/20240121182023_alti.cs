using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentABook.Migrations
{
    /// <inheritdoc />
    public partial class alti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "DiscountRatio",
                table: "Prices",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "DiscountRatio",
                table: "Prices",
                type: "real",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
