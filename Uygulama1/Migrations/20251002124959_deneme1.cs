using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uygulama1.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personeller_Birimler_BirimlerBirimId",
                table: "Personeller");

            migrationBuilder.DropIndex(
                name: "IX_Personeller_BirimlerBirimId",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "BirimlerBirimId",
                table: "Personeller");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_BirimId",
                table: "Personeller",
                column: "BirimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personeller_Birimler_BirimId",
                table: "Personeller",
                column: "BirimId",
                principalTable: "Birimler",
                principalColumn: "BirimId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personeller_Birimler_BirimId",
                table: "Personeller");

            migrationBuilder.DropIndex(
                name: "IX_Personeller_BirimId",
                table: "Personeller");

            migrationBuilder.AddColumn<int>(
                name: "BirimlerBirimId",
                table: "Personeller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_BirimlerBirimId",
                table: "Personeller",
                column: "BirimlerBirimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personeller_Birimler_BirimlerBirimId",
                table: "Personeller",
                column: "BirimlerBirimId",
                principalTable: "Birimler",
                principalColumn: "BirimId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
