using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinTickets.Models.Migrations
{
    public partial class werkaub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestemmingsStad1",
                table: "Treinen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}
