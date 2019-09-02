using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Database.Migrations
{
    public partial class EditAddres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Addres1",
                table: "Orders",
                newName: "Address1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address1",
                table: "Orders",
                newName: "Addres1");
        }
    }
}
