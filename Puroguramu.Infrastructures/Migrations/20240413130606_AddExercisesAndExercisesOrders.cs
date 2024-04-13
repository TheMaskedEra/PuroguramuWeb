using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class AddExercisesAndExercisesOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseOrders",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExerciseBeforeId = table.Column<int>(type: "INTEGER", nullable: true),
                    ExerciseAfterId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseOrders", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_ExerciseOrders_Exercises_ExerciseAfterId",
                        column: x => x.ExerciseAfterId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExerciseOrders_Exercises_ExerciseBeforeId",
                        column: x => x.ExerciseBeforeId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExerciseOrders_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { 1, 1, "Instructions Here", 2, "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { 2, 1, "Instructions Here", 2, "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { 3, 1, "Instructions Here", 2, "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { 1, 2, null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { 3, null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_Title_LessonId",
                table: "Exercises",
                columns: new[] { "Title", "LessonId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseOrders_ExerciseAfterId",
                table: "ExerciseOrders",
                column: "ExerciseAfterId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseOrders_ExerciseBeforeId",
                table: "ExerciseOrders",
                column: "ExerciseBeforeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseOrders");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_Title_LessonId",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
