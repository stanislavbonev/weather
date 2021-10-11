using Microsoft.EntityFrameworkCore.Migrations;

namespace PressureMicroservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pressures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pressures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pressures",
                columns: new[] { "Id", "Value" },
                values: new object[] { 1, 1200m });

            migrationBuilder.InsertData(
                table: "Pressures",
                columns: new[] { "Id", "Value" },
                values: new object[] { 2, 569m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pressures");
        }
    }
}
