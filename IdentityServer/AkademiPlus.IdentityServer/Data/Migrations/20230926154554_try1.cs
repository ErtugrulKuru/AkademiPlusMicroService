using Microsoft.EntityFrameworkCore.Migrations;

namespace AkademiPlus.IdentityServer.Data.Migrations
{
    public partial class try1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City2",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City2",
                table: "AspNetUsers");
        }
    }
}
