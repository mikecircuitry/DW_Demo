using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DW_Demo.Migrations.Customer
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreateDate", "Email", "Name" },
                values: new object[] { 1, new DateTime(2020, 11, 25, 23, 19, 38, 114, DateTimeKind.Local).AddTicks(2087), "Johnny@testlabs.com", "Johnny Test" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreateDate", "Email", "Name" },
                values: new object[] { 2, new DateTime(2020, 11, 25, 23, 19, 38, 116, DateTimeKind.Local).AddTicks(6142), "Susan@testlabs.com", "Susan Test" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreateDate", "Email", "Name" },
                values: new object[] { 3, new DateTime(2020, 11, 25, 23, 19, 38, 116, DateTimeKind.Local).AddTicks(6173), "Mary@testlabs.com", "Mary Test" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CreateDate", "CustomerID", "Name", "State", "StreetAddress", "Zip" },
                values: new object[,]
                {
                    { 1, "Pork Belly", new DateTime(2020, 11, 25, 23, 19, 38, 117, DateTimeKind.Local).AddTicks(9813), 1, "Home", "NY", "123 Test Way Drive", "11111" },
                    { 2, "Pork Belly", new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(252), 2, "Home", "NY", "123 Test Way Drive", "11111" },
                    { 3, "Pork Belly", new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(263), 2, "School", "NY", "314 University Way", "22222" },
                    { 4, "Pork Belly", new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(266), 3, "Secret Lab", "NY", "360 redacted street", "33333" },
                    { 5, "Pork Belly", new DateTime(2020, 11, 25, 23, 19, 38, 118, DateTimeKind.Local).AddTicks(268), 3, "Home", "NY", "123 Test Way Drive", "11111" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerID",
                table: "Addresses",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
