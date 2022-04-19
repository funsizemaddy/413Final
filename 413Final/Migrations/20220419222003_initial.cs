using Microsoft.EntityFrameworkCore.Migrations;

namespace _413Final.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quote = table.Column<string>(nullable: false),
                    author = table.Column<string>(nullable: false),
                    date = table.Column<string>(nullable: true),
                    subject = table.Column<string>(nullable: true),
                    citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "id", "author", "citation", "date", "quote", "subject" },
                values: new object[] { 1, "Buddha", null, null, "There is no path to happiness; happiness is the path", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "id", "author", "citation", "date", "quote", "subject" },
                values: new object[] { 2, "Yoda", null, null, "Do or do not. There is no try.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "id", "author", "citation", "date", "quote", "subject" },
                values: new object[] { 3, "Colin Powell", null, null, "There is no secrets to success. It is the resutl of preparation, hard work, and learning from failure", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
