using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroASP.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureAsIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Brands",
               columns: table => new
               {
                   BrandId = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"), // Configure BrandId as an identity column
                   Name = table.Column<string>(maxLength: 255, fixedLength: true, nullable: true),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Brands", x => x.BrandId);
               });

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    BeerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"), // Configure BeerId as an identity column
                    Name = table.Column<string>(maxLength: 255, fixedLength: true, nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.BeerId);
                    table.ForeignKey(
                        name: "FK_Beers_Brands",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.DropTable(
                name: "Brands");

        }


    }

}
