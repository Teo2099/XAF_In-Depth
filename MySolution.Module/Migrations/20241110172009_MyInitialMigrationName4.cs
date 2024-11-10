using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySolution.Module.Migrations
{
    /// <inheritdoc />
    public partial class MyInitialMigrationName4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PhoneNumberID",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PhoneNumberID",
                table: "Employees",
                column: "PhoneNumberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PhoneNumbers_PhoneNumberID",
                table: "Employees",
                column: "PhoneNumberID",
                principalTable: "PhoneNumbers",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PhoneNumbers_PhoneNumberID",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PhoneNumberID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumberID",
                table: "Employees");
        }
    }
}
