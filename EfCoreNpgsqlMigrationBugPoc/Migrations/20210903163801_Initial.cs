using EfCoreNpgsqlMigrationBugPoc.First;
using EfCoreNpgsqlMigrationBugPoc.Second;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EfCoreNpgsqlMigrationBugPoc.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:first_some_state", "one,two")
                .Annotation("Npgsql:Enum:second_some_state", "three,four,five");

            migrationBuilder.CreateTable(
                name: "Ones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    State = table.Column<SomeState>(type: "first_some_state", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Twos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    State = table.Column<SomeState>(type: "second_some_state", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Twos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ones");

            migrationBuilder.DropTable(
                name: "Twos");
        }
    }
}
