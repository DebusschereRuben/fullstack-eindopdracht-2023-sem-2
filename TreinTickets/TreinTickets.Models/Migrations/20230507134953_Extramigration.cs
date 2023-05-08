using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreinTickets.Models.Migrations
{
    public partial class Extramigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ritten_Steden_EindbestemmingsStadId",
                table: "Ritten");

            migrationBuilder.DropForeignKey(
                name: "FK_Ritten_Steden_VertrekstadId",
                table: "Ritten");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinen_Steden_BestemmingsStad",
                table: "Treinen");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinen_Steden_Vertrekstad",
                table: "Treinen");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_RitId",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RitId",
                table: "Tickets",
                column: "RitId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ritten_TreinKlasses_EindbestemmingsStadId",
                table: "Ritten",
                column: "EindbestemmingsStadId",
                principalTable: "TreinKlasses",
                principalColumn: "KlasseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ritten_TreinKlasses_VertrekstadId",
                table: "Ritten",
                column: "VertrekstadId",
                principalTable: "TreinKlasses",
                principalColumn: "KlasseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinen_TreinKlasses_BestemmingsStad",
                table: "Treinen",
                column: "BestemmingsStad",
                principalTable: "TreinKlasses",
                principalColumn: "KlasseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinen_TreinKlasses_Vertrekstad",
                table: "Treinen",
                column: "Vertrekstad",
                principalTable: "TreinKlasses",
                principalColumn: "KlasseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ritten_TreinKlasses_EindbestemmingsStadId",
                table: "Ritten");

            migrationBuilder.DropForeignKey(
                name: "FK_Ritten_TreinKlasses_VertrekstadId",
                table: "Ritten");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinen_TreinKlasses_BestemmingsStad",
                table: "Treinen");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinen_TreinKlasses_Vertrekstad",
                table: "Treinen");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_RitId",
                table: "Tickets");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RitId",
                table: "Tickets",
                column: "RitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ritten_Steden_EindbestemmingsStadId",
                table: "Ritten",
                column: "EindbestemmingsStadId",
                principalTable: "Steden",
                principalColumn: "StadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ritten_Steden_VertrekstadId",
                table: "Ritten",
                column: "VertrekstadId",
                principalTable: "Steden",
                principalColumn: "StadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinen_Steden_BestemmingsStad",
                table: "Treinen",
                column: "BestemmingsStad",
                principalTable: "Steden",
                principalColumn: "StadId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinen_Steden_Vertrekstad",
                table: "Treinen",
                column: "Vertrekstad",
                principalTable: "Steden",
                principalColumn: "StadId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
