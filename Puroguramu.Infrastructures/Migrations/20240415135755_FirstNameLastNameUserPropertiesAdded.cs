using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class FirstNameLastNameUserPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "01b06b31-e8c8-4e23-bafd-8b7086febec6", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "8792f63e-5a1d-4731-b5ee-7a0417a776ab", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "bdf1f2ac-0b96-4ff0-a967-b66aa5071000", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "c881cf98-62bb-4199-ac16-c64269413832", "2i2" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "657e4a11-e883-4d71-9916-5501ccba0b19", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "cc44892a-1e50-4fb9-a158-93a47b46885f", "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "60749e3c-3e06-4361-9d06-959bf29335b4", "cc44892a-1e50-4fb9-a158-93a47b46885f", "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "a244bc92-7968-4b7e-9b5a-c654a0a9a357", "cc44892a-1e50-4fb9-a158-93a47b46885f", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "bb21181d-4fe9-4c79-8766-41aa7acb76dc", "60749e3c-3e06-4361-9d06-959bf29335b4", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "c032fccb-4d25-4ccb-a035-ee985f301da6", "60749e3c-3e06-4361-9d06-959bf29335b4", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "deac8366-ced2-4b14-86df-7de599338265", "60749e3c-3e06-4361-9d06-959bf29335b4", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "5d9e5e19-83d6-4774-a3b3-f97eac071ea9", 1, "Instructions Here", "deac8366-ced2-4b14-86df-7de599338265", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "9f1d612e-5090-46c3-9197-7a018dd31839", 1, "Instructions Here", "deac8366-ced2-4b14-86df-7de599338265", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "b88dd734-62fd-40eb-b9c8-21cac1a37931", 1, "Instructions Here", "deac8366-ced2-4b14-86df-7de599338265", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "bb21181d-4fe9-4c79-8766-41aa7acb76dc", null, "deac8366-ced2-4b14-86df-7de599338265" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "c032fccb-4d25-4ccb-a035-ee985f301da6", "deac8366-ced2-4b14-86df-7de599338265", null });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "deac8366-ced2-4b14-86df-7de599338265", "bb21181d-4fe9-4c79-8766-41aa7acb76dc", "c032fccb-4d25-4ccb-a035-ee985f301da6" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "5d9e5e19-83d6-4774-a3b3-f97eac071ea9", "b88dd734-62fd-40eb-b9c8-21cac1a37931", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "9f1d612e-5090-46c3-9197-7a018dd31839", null, "b88dd734-62fd-40eb-b9c8-21cac1a37931" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "b88dd734-62fd-40eb-b9c8-21cac1a37931", "9f1d612e-5090-46c3-9197-7a018dd31839", "5d9e5e19-83d6-4774-a3b3-f97eac071ea9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "a244bc92-7968-4b7e-9b5a-c654a0a9a357");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "5d9e5e19-83d6-4774-a3b3-f97eac071ea9");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "9f1d612e-5090-46c3-9197-7a018dd31839");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "b88dd734-62fd-40eb-b9c8-21cac1a37931");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "01b06b31-e8c8-4e23-bafd-8b7086febec6");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "8792f63e-5a1d-4731-b5ee-7a0417a776ab");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "bdf1f2ac-0b96-4ff0-a967-b66aa5071000");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "c881cf98-62bb-4199-ac16-c64269413832");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "657e4a11-e883-4d71-9916-5501ccba0b19");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "bb21181d-4fe9-4c79-8766-41aa7acb76dc");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "c032fccb-4d25-4ccb-a035-ee985f301da6");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "deac8366-ced2-4b14-86df-7de599338265");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "5d9e5e19-83d6-4774-a3b3-f97eac071ea9");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "9f1d612e-5090-46c3-9197-7a018dd31839");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "b88dd734-62fd-40eb-b9c8-21cac1a37931");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "bb21181d-4fe9-4c79-8766-41aa7acb76dc");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "c032fccb-4d25-4ccb-a035-ee985f301da6");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "deac8366-ced2-4b14-86df-7de599338265");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "60749e3c-3e06-4361-9d06-959bf29335b4");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "cc44892a-1e50-4fb9-a158-93a47b46885f");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
