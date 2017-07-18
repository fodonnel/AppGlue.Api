using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppGlue.Api.Database.Migrations
{
    public partial class Migration_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BiosDate = table.Column<DateTime>(nullable: true),
                    BiosVersion = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 50, nullable: true),
                    MemoryInKb = table.Column<long>(nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(maxLength: 50, nullable: true),
                    SerialNumber = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
