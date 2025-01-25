using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlphaFarha.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class IntialMigrate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MRFs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MRFNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GeneratedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MRFDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeliverTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GeneratedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRFs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MRFItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MRFNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReqQtyInitial = table.Column<double>(type: "float", nullable: false),
                    ReqQty = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReqDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QtyIssued = table.Column<double>(type: "float", nullable: false),
                    IssuedOnStore = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArrivedIssuedOnStore = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LPO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LPODate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VATAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRFItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MRFItems_MRFs_MRFNo",
                        column: x => x.MRFNo,
                        principalTable: "MRFs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Active", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("2c7d2a78-232c-4946-a743-4408eceaad11"), "Y", "PJ0001", "Project 1" },
                    { new Guid("63667fa3-6088-4583-a329-f1fdcc815c2a"), "Y", "PJ0002", "Project 2" },
                    { new Guid("cde9d7a3-01f5-4a57-96dc-57e1ac89685e"), "Y", "PJ0003", "Project 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MRFItems_MRFNo",
                table: "MRFItems",
                column: "MRFNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MRFItems");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "MRFs");
        }
    }
}
