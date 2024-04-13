using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class AddLessonOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonOrders",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "INTEGER", nullable: false),
                    LessonBeforeId = table.Column<int>(type: "INTEGER", nullable: true),
                    LessonAfterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonOrders", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_LessonOrders_Lessons_LessonAfterId",
                        column: x => x.LessonAfterId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonOrders_Lessons_LessonBeforeId",
                        column: x => x.LessonBeforeId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonOrders_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { 1, 2, null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsVisible",
                value: true);

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { 3, 1, "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { 3, null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_LessonOrders_LessonAfterId",
                table: "LessonOrders",
                column: "LessonAfterId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonOrders_LessonBeforeId",
                table: "LessonOrders",
                column: "LessonBeforeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonOrders");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsVisible",
                value: false);
        }
    }
}
