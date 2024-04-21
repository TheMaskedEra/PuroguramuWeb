using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class EmailAndRegistrationNumberUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23433b7d-54c4-4d22-afe6-d29cd3f0c0a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c08a35d8-82c4-4180-bea6-c56e6063f794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e785f4c1-67d9-4e5f-9b5e-abc879bf5557");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f49f5e2d-0176-4ac6-9099-b284ddc2c848");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "1136e78a-e25d-4c7f-95a6-907451b255e4");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "064c53e6-025b-418b-b2f3-221bba865411");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "4be6ce54-fad1-4e8d-a378-ff86aba9aeaa");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "d642fd5e-c1e2-495c-90df-79f71f0e4d43");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "1bfce0db-9aec-4df7-b332-2b95db374c43");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "73985de4-cd90-4c8e-8ea1-f0c109439b2b");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "aa6f2a1b-b616-4a7a-9d7e-ebbeda19ff7a");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "083902d6-d787-4eb9-946c-ba9913f60076");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "514f2a3f-6d33-48ec-bdb3-4a4664cb0804");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "9d8999d3-7a21-4d00-a74b-6617df37768f");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "b41ad672-4b7c-4abd-a6c0-a65286f3af83");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "064c53e6-025b-418b-b2f3-221bba865411");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "4be6ce54-fad1-4e8d-a378-ff86aba9aeaa");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "d642fd5e-c1e2-495c-90df-79f71f0e4d43");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "cb483d4b-daaa-4ee3-9568-fd09a76f62de");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "514f2a3f-6d33-48ec-bdb3-4a4664cb0804");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "9d8999d3-7a21-4d00-a74b-6617df37768f");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "b41ad672-4b7c-4abd-a6c0-a65286f3af83");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "1b46fcc9-34ee-4154-9d34-f895c753447b");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "89c42b5e-19eb-4a3b-bf9f-bdc113202edd");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_AspNetUsers_RegistrationNumber",
                table: "AspNetUsers",
                column: "RegistrationNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10613db7-ddbf-48b1-99b2-4344cfe49914", "10613db7-ddbf-48b1-99b2-4344cfe49914", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63a05289-0fa2-455c-97d5-ed85d1f3ef40", "63a05289-0fa2-455c-97d5-ed85d1f3ef40", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff935a7b-947d-4681-8322-575b683b0fea", "ff935a7b-947d-4681-8322-575b683b0fea", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "a819f046-ec99-4b5b-ad72-05bdb25d10ff", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "b9cbc422-21f7-4cfd-85b4-8042ce07d373", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "cfb0675c-1227-4b58-ace5-5a69a81f9690", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "e57f52df-d656-4fc1-8f91-dc5994c3751c", "2i2" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "2062b093-6773-4fd3-bbfa-047131e9002d", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "9dd30e42-8cdb-4e72-8ab7-60b1918f2d18", "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "7020fc68-0641-454e-8056-4c9725d07eb3", "9dd30e42-8cdb-4e72-8ab7-60b1918f2d18", "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "c9cff2c5-8799-41f1-b2bb-64069efb9681", "9dd30e42-8cdb-4e72-8ab7-60b1918f2d18", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "2bd3181f-44fb-4212-8d7d-0e16db9baf41", "7020fc68-0641-454e-8056-4c9725d07eb3", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "5f26e32d-31da-47d9-a04b-e49907c45015", "7020fc68-0641-454e-8056-4c9725d07eb3", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "79ce319d-963f-472f-9743-e8e16855a039", "7020fc68-0641-454e-8056-4c9725d07eb3", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "07d52aa0-0211-4253-b9a0-25cc3491ea0e", 1, "Instructions Here", "5f26e32d-31da-47d9-a04b-e49907c45015", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "bbaccb82-248e-4328-8b6d-172a5f1f404e", 1, "Instructions Here", "5f26e32d-31da-47d9-a04b-e49907c45015", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "f58bd871-c329-4afd-a285-f71c0a1d199b", 1, "Instructions Here", "5f26e32d-31da-47d9-a04b-e49907c45015", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "2bd3181f-44fb-4212-8d7d-0e16db9baf41", "5f26e32d-31da-47d9-a04b-e49907c45015", null });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "5f26e32d-31da-47d9-a04b-e49907c45015", "79ce319d-963f-472f-9743-e8e16855a039", "2bd3181f-44fb-4212-8d7d-0e16db9baf41" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "79ce319d-963f-472f-9743-e8e16855a039", null, "5f26e32d-31da-47d9-a04b-e49907c45015" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "07d52aa0-0211-4253-b9a0-25cc3491ea0e", "bbaccb82-248e-4328-8b6d-172a5f1f404e", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "bbaccb82-248e-4328-8b6d-172a5f1f404e", "f58bd871-c329-4afd-a285-f71c0a1d199b", "07d52aa0-0211-4253-b9a0-25cc3491ea0e" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "f58bd871-c329-4afd-a285-f71c0a1d199b", null, "bbaccb82-248e-4328-8b6d-172a5f1f404e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_AspNetUsers_RegistrationNumber",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10613db7-ddbf-48b1-99b2-4344cfe49914");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63a05289-0fa2-455c-97d5-ed85d1f3ef40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff935a7b-947d-4681-8322-575b683b0fea");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "c9cff2c5-8799-41f1-b2bb-64069efb9681");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "07d52aa0-0211-4253-b9a0-25cc3491ea0e");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "bbaccb82-248e-4328-8b6d-172a5f1f404e");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "f58bd871-c329-4afd-a285-f71c0a1d199b");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "a819f046-ec99-4b5b-ad72-05bdb25d10ff");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b9cbc422-21f7-4cfd-85b4-8042ce07d373");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "cfb0675c-1227-4b58-ace5-5a69a81f9690");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "e57f52df-d656-4fc1-8f91-dc5994c3751c");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "2062b093-6773-4fd3-bbfa-047131e9002d");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "2bd3181f-44fb-4212-8d7d-0e16db9baf41");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "5f26e32d-31da-47d9-a04b-e49907c45015");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "79ce319d-963f-472f-9743-e8e16855a039");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "07d52aa0-0211-4253-b9a0-25cc3491ea0e");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "bbaccb82-248e-4328-8b6d-172a5f1f404e");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "f58bd871-c329-4afd-a285-f71c0a1d199b");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "2bd3181f-44fb-4212-8d7d-0e16db9baf41");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "79ce319d-963f-472f-9743-e8e16855a039");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "5f26e32d-31da-47d9-a04b-e49907c45015");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "7020fc68-0641-454e-8056-4c9725d07eb3");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "9dd30e42-8cdb-4e72-8ab7-60b1918f2d18");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23433b7d-54c4-4d22-afe6-d29cd3f0c0a3", "23433b7d-54c4-4d22-afe6-d29cd3f0c0a3", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c08a35d8-82c4-4180-bea6-c56e6063f794", "c08a35d8-82c4-4180-bea6-c56e6063f794", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e785f4c1-67d9-4e5f-9b5e-abc879bf5557", "e785f4c1-67d9-4e5f-9b5e-abc879bf5557", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "1bfce0db-9aec-4df7-b332-2b95db374c43", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "73985de4-cd90-4c8e-8ea1-f0c109439b2b", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "aa6f2a1b-b616-4a7a-9d7e-ebbeda19ff7a", "2i2" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "cb483d4b-daaa-4ee3-9568-fd09a76f62de", "2i3" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "083902d6-d787-4eb9-946c-ba9913f60076", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "89c42b5e-19eb-4a3b-bf9f-bdc113202edd", "C#" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GroupId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f49f5e2d-0176-4ac6-9099-b284ddc2c848", 0, "4f916994-cc3b-4b13-8237-af740512015a", "a.vandenbroeck@student.helmo.be", false, "Alexis", "cb483d4b-daaa-4ee3-9568-fd09a76f62de", "LastName", false, null, null, null, null, null, false, "E200971", "94407c07-4fd0-4506-bfe7-8999552fcb74", false, null });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "1136e78a-e25d-4c7f-95a6-907451b255e4", "89c42b5e-19eb-4a3b-bf9f-bdc113202edd", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "1b46fcc9-34ee-4154-9d34-f895c753447b", "89c42b5e-19eb-4a3b-bf9f-bdc113202edd", "Beginners" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "514f2a3f-6d33-48ec-bdb3-4a4664cb0804", "1b46fcc9-34ee-4154-9d34-f895c753447b", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "9d8999d3-7a21-4d00-a74b-6617df37768f", "1b46fcc9-34ee-4154-9d34-f895c753447b", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "b41ad672-4b7c-4abd-a6c0-a65286f3af83", "1b46fcc9-34ee-4154-9d34-f895c753447b", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "064c53e6-025b-418b-b2f3-221bba865411", 1, "Instructions Here", "b41ad672-4b7c-4abd-a6c0-a65286f3af83", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "4be6ce54-fad1-4e8d-a378-ff86aba9aeaa", 1, "Instructions Here", "b41ad672-4b7c-4abd-a6c0-a65286f3af83", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "d642fd5e-c1e2-495c-90df-79f71f0e4d43", 1, "Instructions Here", "b41ad672-4b7c-4abd-a6c0-a65286f3af83", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "514f2a3f-6d33-48ec-bdb3-4a4664cb0804", "b41ad672-4b7c-4abd-a6c0-a65286f3af83", null });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "9d8999d3-7a21-4d00-a74b-6617df37768f", null, "b41ad672-4b7c-4abd-a6c0-a65286f3af83" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "b41ad672-4b7c-4abd-a6c0-a65286f3af83", "9d8999d3-7a21-4d00-a74b-6617df37768f", "514f2a3f-6d33-48ec-bdb3-4a4664cb0804" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "064c53e6-025b-418b-b2f3-221bba865411", null, "d642fd5e-c1e2-495c-90df-79f71f0e4d43" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "4be6ce54-fad1-4e8d-a378-ff86aba9aeaa", "d642fd5e-c1e2-495c-90df-79f71f0e4d43", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "d642fd5e-c1e2-495c-90df-79f71f0e4d43", "064c53e6-025b-418b-b2f3-221bba865411", "4be6ce54-fad1-4e8d-a378-ff86aba9aeaa" });
        }
    }
}
