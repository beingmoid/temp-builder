using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication11.Migrations
{
    public partial class First12172019953 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    text = table.Column<string>(nullable: true),
                    TypeOfResponse = table.Column<string>(nullable: true),
                    IsScored = table.Column<bool>(nullable: false),
                    MaxScore = table.Column<int>(nullable: false),
                    Scored = table.Column<int>(nullable: false),
                    IsMandatory = table.Column<bool>(nullable: false),
                    IsMultiSelection = table.Column<bool>(nullable: false),
                    IsNotified = table.Column<bool>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Questions_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TemplateId",
                table: "Questions",
                column: "TemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Templates");
        }
    }
}
