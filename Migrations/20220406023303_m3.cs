using Microsoft.EntityFrameworkCore.Migrations;

namespace FishingTournament02.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventCapacity = table.Column<int>(type: "int", nullable: false),
                    EventURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventCost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
