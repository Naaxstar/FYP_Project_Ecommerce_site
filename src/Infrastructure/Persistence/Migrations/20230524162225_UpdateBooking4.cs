using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FYP.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBooking4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Bookings");
        }
    }
}
