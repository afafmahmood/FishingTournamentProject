using Microsoft.EntityFrameworkCore.Migrations;

namespace FishingTournament02.Migrations
{
    public partial class BLF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegister_Events_EventID",
                table: "EventRegister");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventRegister",
                table: "EventRegister");

            migrationBuilder.DropIndex(
                name: "IX_EventRegister_EventID",
                table: "EventRegister");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "EventRegister");

            migrationBuilder.RenameTable(
                name: "EventRegister",
                newName: "EventRegisters");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "GuestLastName",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "GuestFirstName",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(160)",
                oldMaxLength: 160);

            migrationBuilder.AlterColumn<int>(
                name: "EventID",
                table: "EventRegisters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AddColumn<int>(
                name: "EventsEventID",
                table: "EventRegisters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZIP",
                table: "EventRegisters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventRegisters",
                table: "EventRegisters",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegisters_EventsEventID",
                table: "EventRegisters",
                column: "EventsEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegisters_Events_EventsEventID",
                table: "EventRegisters",
                column: "EventsEventID",
                principalTable: "Events",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRegisters_Events_EventsEventID",
                table: "EventRegisters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventRegisters",
                table: "EventRegisters");

            migrationBuilder.DropIndex(
                name: "IX_EventRegisters_EventsEventID",
                table: "EventRegisters");

            migrationBuilder.DropColumn(
                name: "EventsEventID",
                table: "EventRegisters");

            migrationBuilder.DropColumn(
                name: "ZIP",
                table: "EventRegisters");

            migrationBuilder.RenameTable(
                name: "EventRegisters",
                newName: "EventRegister");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "EventRegister",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "EventRegister",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "EventRegister",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GuestLastName",
                table: "EventRegister",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GuestFirstName",
                table: "EventRegister",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EventRegister",
                type: "nvarchar(160)",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EventID",
                table: "EventRegister",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "EventRegister",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "EventRegister",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "EventRegister",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventRegister",
                table: "EventRegister",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegister_EventID",
                table: "EventRegister",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRegister_Events_EventID",
                table: "EventRegister",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
