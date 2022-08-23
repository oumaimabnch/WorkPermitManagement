using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkPermitManagement.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkPermit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true),
                    passportNumber = table.Column<string>(nullable: true),
                    function = table.Column<string>(nullable: true),
                    employer = table.Column<string>(nullable: true),
                    taxIdNumber = table.Column<string>(nullable: true),
                    socialSecurityNumber = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    salaryInNumbers = table.Column<string>(nullable: true),
                    salaryInWords = table.Column<string>(nullable: true),
                    NaturalAdvantage = table.Column<string>(nullable: true),
                    otherAdavantages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPermit", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPermit");
        }
    }
}
