using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class UserSeedAlexis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "014eb349-88a2-4262-a461-d9ee111495c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430166a7-b1c6-4d4d-9745-3337d0293440");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b11580dd-350f-4b2e-a68e-e253c511e2ac");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "83c17675-b7c9-4de3-91ab-ef7189f82f91");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "1e8558c0-cc59-471d-90f2-3e53a378b236");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "50be4e0c-980c-4956-a547-c4748a16640a");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "dba8be7e-2166-4e28-a146-8ef232eb55ee");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "48ee7054-66c7-4561-a31b-3e3e209f8cbb");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "62f4b178-6a07-451a-b981-872f1f9f511d");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "87c1d836-a8eb-4ee8-abe1-7396a865fa33");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "f0725632-2a8e-45fa-a1ab-ad5bc76bc501");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "f34847d7-66ce-4bb3-8e1f-7497a18624fd");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "6af64676-6a05-4d26-a1e8-a6a8f1b5bc90");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "b90b9dca-bfd8-4040-8a52-7e2744970c75");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "d0cd4abf-1d5e-41cd-af74-2859cf375130");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "1e8558c0-cc59-471d-90f2-3e53a378b236");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "50be4e0c-980c-4956-a547-c4748a16640a");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "dba8be7e-2166-4e28-a146-8ef232eb55ee");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "6af64676-6a05-4d26-a1e8-a6a8f1b5bc90");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "b90b9dca-bfd8-4040-8a52-7e2744970c75");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "d0cd4abf-1d5e-41cd-af74-2859cf375130");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "990e61bd-6aef-4caf-8c0b-629f14ee846e");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "85eedd5a-5a41-42b0-be88-1add870d4c87");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "014eb349-88a2-4262-a461-d9ee111495c7", "014eb349-88a2-4262-a461-d9ee111495c7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "430166a7-b1c6-4d4d-9745-3337d0293440", "430166a7-b1c6-4d4d-9745-3337d0293440", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b11580dd-350f-4b2e-a68e-e253c511e2ac", "b11580dd-350f-4b2e-a68e-e253c511e2ac", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "48ee7054-66c7-4561-a31b-3e3e209f8cbb", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "62f4b178-6a07-451a-b981-872f1f9f511d", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "87c1d836-a8eb-4ee8-abe1-7396a865fa33", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "f0725632-2a8e-45fa-a1ab-ad5bc76bc501", "2i2" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "85eedd5a-5a41-42b0-be88-1add870d4c87", "C#" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "f34847d7-66ce-4bb3-8e1f-7497a18624fd", "Java" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "83c17675-b7c9-4de3-91ab-ef7189f82f91", "85eedd5a-5a41-42b0-be88-1add870d4c87", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "990e61bd-6aef-4caf-8c0b-629f14ee846e", "85eedd5a-5a41-42b0-be88-1add870d4c87", "Beginners" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "6af64676-6a05-4d26-a1e8-a6a8f1b5bc90", "990e61bd-6aef-4caf-8c0b-629f14ee846e", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "b90b9dca-bfd8-4040-8a52-7e2744970c75", "990e61bd-6aef-4caf-8c0b-629f14ee846e", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "d0cd4abf-1d5e-41cd-af74-2859cf375130", "990e61bd-6aef-4caf-8c0b-629f14ee846e", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "1e8558c0-cc59-471d-90f2-3e53a378b236", 1, "Instructions Here", "d0cd4abf-1d5e-41cd-af74-2859cf375130", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "50be4e0c-980c-4956-a547-c4748a16640a", 1, "Instructions Here", "d0cd4abf-1d5e-41cd-af74-2859cf375130", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "dba8be7e-2166-4e28-a146-8ef232eb55ee", 1, "Instructions Here", "d0cd4abf-1d5e-41cd-af74-2859cf375130", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "6af64676-6a05-4d26-a1e8-a6a8f1b5bc90", null, "d0cd4abf-1d5e-41cd-af74-2859cf375130" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "b90b9dca-bfd8-4040-8a52-7e2744970c75", "d0cd4abf-1d5e-41cd-af74-2859cf375130", null });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "d0cd4abf-1d5e-41cd-af74-2859cf375130", "6af64676-6a05-4d26-a1e8-a6a8f1b5bc90", "b90b9dca-bfd8-4040-8a52-7e2744970c75" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "1e8558c0-cc59-471d-90f2-3e53a378b236", null, "50be4e0c-980c-4956-a547-c4748a16640a" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "50be4e0c-980c-4956-a547-c4748a16640a", "1e8558c0-cc59-471d-90f2-3e53a378b236", "dba8be7e-2166-4e28-a146-8ef232eb55ee" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "dba8be7e-2166-4e28-a146-8ef232eb55ee", "50be4e0c-980c-4956-a547-c4748a16640a", null });
        }
    }
}
