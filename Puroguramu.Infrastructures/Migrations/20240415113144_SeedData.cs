using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "0c5003cf-2254-4737-be29-252eaaaba2ce", "2i2" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "21233326-fd5e-440f-8d6d-1ea6c1775a71", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "462d1685-32a7-4729-b3a6-f0f2d75ff916", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "b7e420fa-1a00-4dd5-bd04-b61fc9c35678", "2i1" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "155f8183-e3d7-41f6-9b17-df3aa3110814", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "f3172d77-738b-45ea-bb4f-a033e6259a17", "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "21b7f27d-0f76-45b9-a67e-6b631357d2e8", "f3172d77-738b-45ea-bb4f-a033e6259a17", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "62719556-63cc-4b8a-ba2c-a20e7edbc7df", "f3172d77-738b-45ea-bb4f-a033e6259a17", "Beginners" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "0fb0dc5b-5316-47bc-88d5-31cd3fdc314f", "62719556-63cc-4b8a-ba2c-a20e7edbc7df", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "2a4ebd67-ebeb-49e9-8362-29603500db96", "62719556-63cc-4b8a-ba2c-a20e7edbc7df", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "74d02216-303e-442a-9c4a-40e6ac853f39", "62719556-63cc-4b8a-ba2c-a20e7edbc7df", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "240c3dd6-28d7-4626-8179-8f54f6543d8c", 1, "Instructions Here", "2a4ebd67-ebeb-49e9-8362-29603500db96", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "da484893-2ded-4fef-87ad-11dcc46d9b8d", 1, "Instructions Here", "2a4ebd67-ebeb-49e9-8362-29603500db96", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "e53a6542-17d4-4cd4-8c30-9b824e9db91d", 1, "Instructions Here", "2a4ebd67-ebeb-49e9-8362-29603500db96", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "0fb0dc5b-5316-47bc-88d5-31cd3fdc314f", null, "2a4ebd67-ebeb-49e9-8362-29603500db96" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "2a4ebd67-ebeb-49e9-8362-29603500db96", "0fb0dc5b-5316-47bc-88d5-31cd3fdc314f", "74d02216-303e-442a-9c4a-40e6ac853f39" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "74d02216-303e-442a-9c4a-40e6ac853f39", "2a4ebd67-ebeb-49e9-8362-29603500db96", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "240c3dd6-28d7-4626-8179-8f54f6543d8c", "da484893-2ded-4fef-87ad-11dcc46d9b8d", "e53a6542-17d4-4cd4-8c30-9b824e9db91d" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "da484893-2ded-4fef-87ad-11dcc46d9b8d", null, "240c3dd6-28d7-4626-8179-8f54f6543d8c" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "e53a6542-17d4-4cd4-8c30-9b824e9db91d", "240c3dd6-28d7-4626-8179-8f54f6543d8c", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "21b7f27d-0f76-45b9-a67e-6b631357d2e8");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "240c3dd6-28d7-4626-8179-8f54f6543d8c");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "da484893-2ded-4fef-87ad-11dcc46d9b8d");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "e53a6542-17d4-4cd4-8c30-9b824e9db91d");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "0c5003cf-2254-4737-be29-252eaaaba2ce");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "21233326-fd5e-440f-8d6d-1ea6c1775a71");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "462d1685-32a7-4729-b3a6-f0f2d75ff916");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b7e420fa-1a00-4dd5-bd04-b61fc9c35678");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "155f8183-e3d7-41f6-9b17-df3aa3110814");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "0fb0dc5b-5316-47bc-88d5-31cd3fdc314f");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "2a4ebd67-ebeb-49e9-8362-29603500db96");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "74d02216-303e-442a-9c4a-40e6ac853f39");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "240c3dd6-28d7-4626-8179-8f54f6543d8c");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "da484893-2ded-4fef-87ad-11dcc46d9b8d");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "e53a6542-17d4-4cd4-8c30-9b824e9db91d");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "0fb0dc5b-5316-47bc-88d5-31cd3fdc314f");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "74d02216-303e-442a-9c4a-40e6ac853f39");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "2a4ebd67-ebeb-49e9-8362-29603500db96");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "62719556-63cc-4b8a-ba2c-a20e7edbc7df");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "f3172d77-738b-45ea-bb4f-a033e6259a17");
        }
    }
}
