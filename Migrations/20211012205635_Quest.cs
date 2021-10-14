using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Quest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Quest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Var_Answ1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Var_Answ2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Var_Answ3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
