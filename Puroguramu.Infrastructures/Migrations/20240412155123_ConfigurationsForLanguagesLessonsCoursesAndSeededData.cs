using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class ConfigurationsForLanguagesLessonsCoursesAndSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Lessons_Title",
                table: "Lessons",
                column: "Title");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Courses_Title_LanguageId",
                table: "Courses",
                columns: new[] { "Title", "LanguageId" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { 1, 1, "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { 2, 1, "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { 1, 1, "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { 2, 1, "", false, "Functions" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Lessons_Title",
                table: "Lessons");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Courses_Title_LanguageId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Variables");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Functions");
        }
    }
}
