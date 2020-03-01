using Microsoft.EntityFrameworkCore.Migrations;

namespace aws_postman.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsermessageId",
                table: "Emails",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Usermessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    source = table.Column<string>(nullable: false),
                    subject = table.Column<string>(nullable: false),
                    body = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usermessages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UsermessageId",
                table: "Emails",
                column: "UsermessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Usermessages_UsermessageId",
                table: "Emails",
                column: "UsermessageId",
                principalTable: "Usermessages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Usermessages_UsermessageId",
                table: "Emails");

            migrationBuilder.DropTable(
                name: "Usermessages");

            migrationBuilder.DropIndex(
                name: "IX_Emails_UsermessageId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "UsermessageId",
                table: "Emails");
        }
    }
}
