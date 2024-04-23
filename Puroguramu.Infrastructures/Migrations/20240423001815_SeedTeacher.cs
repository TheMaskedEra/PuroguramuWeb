using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class SeedTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23dc02ce-c57b-469d-a094-4553d335b4f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87107a97-bba6-4c64-8b7b-03d49958eca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff0eda17-7c93-4f5d-9888-806e5cc2ec37");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "64ec4d5e-2e6b-4d46-863d-8a36185a5473");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "0f7e84ed-8465-49c6-8092-9ff6642131b8");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "53979db5-9c2b-4f5c-9ab5-c851fa714ae8");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "5d618db4-e4d3-49a3-a2dc-51e6daa3bad5");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b6dfd114-c8e2-4953-ae06-2f11bc51ce9d");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "bb31a196-9438-4868-902f-54a72c32b7f1");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "d866a919-d411-4243-afad-ac1960255dc3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "ef8c0f27-a7b2-4a9a-ac88-43c25fe4b7c2");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "0fa30775-189f-4943-beef-1b6543c06806");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "1dbf8abf-404a-40b3-820f-9c80e511713a");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "591a5c7c-710c-400e-b64c-3c52a7ae147c");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "672c6cb2-aff6-4a23-ba1d-7974faad18fa");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "0f7e84ed-8465-49c6-8092-9ff6642131b8");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "53979db5-9c2b-4f5c-9ab5-c851fa714ae8");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "5d618db4-e4d3-49a3-a2dc-51e6daa3bad5");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "1dbf8abf-404a-40b3-820f-9c80e511713a");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "672c6cb2-aff6-4a23-ba1d-7974faad18fa");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "591a5c7c-710c-400e-b64c-3c52a7ae147c");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "3ae3e88f-5fe8-42e7-a1ff-e81032ef9bfb");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "78da7aea-37e5-49f7-bbc1-369c77c29e2d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46fbfafb-1f5a-4742-a584-4942fed5b5b9", "46fbfafb-1f5a-4742-a584-4942fed5b5b9", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51bb534e-79c5-48b7-8340-b491a0e778db", "51bb534e-79c5-48b7-8340-b491a0e778db", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6dd437c2-15bd-4850-887b-62edc43d88c6", "6dd437c2-15bd-4850-887b-62edc43d88c6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GroupId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicturePath", "RegistrationNumber", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90fbb053-5bee-47f7-8623-0d85c32cc8c7", 0, "be0c2aca-2c4f-4e60-8ed5-b8d375a8de31", "g.vanass@helmo.be", false, "Grégory", null, "Van Ass", false, null, "G.VANASS@HELMO.BE", "G.VANASS@HELMO.BE", "AQAAAAEAACcQAAAAEE2r8e9FKor+syHvFHh3nVQ028YGyQViGEu6W1Fpqva7Ueg7iFHWp3hiei7IQQ+IJA==", null, false, null, "P210020", "8ee95672-9bba-4f37-890d-0fa7b65a174e", false, "g.vanass@helmo.be" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "0f3345be-c57e-4d2a-a021-ee8bb4f983d3", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "4ca6fbce-95c7-4dae-98b8-ada62dc357d7", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "547b5dbc-87aa-4949-8ba0-1902ad000b22", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "eeca3d56-8986-4102-ab33-e6b34315e29b", "2i2" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "5ccc0afc-3ffd-4787-8df0-d34065983605", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "df1ca4a2-568c-4a74-85e9-a031d89dc957", "C#" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "46fbfafb-1f5a-4742-a584-4942fed5b5b9", "90fbb053-5bee-47f7-8623-0d85c32cc8c7" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "99c32534-ac3a-47f5-993d-9b0f41dc415c", "df1ca4a2-568c-4a74-85e9-a031d89dc957", "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "dd74a194-b2b5-49fe-a316-be04dd3f490e", "df1ca4a2-568c-4a74-85e9-a031d89dc957", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "71115d6c-0f00-47d3-9b63-94abf61ebce1", "99c32534-ac3a-47f5-993d-9b0f41dc415c", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "e02889dd-7c48-4e86-822a-1b37ccb02bd0", "99c32534-ac3a-47f5-993d-9b0f41dc415c", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "f982c60c-937d-472f-a92f-38ba1b7b902b", "99c32534-ac3a-47f5-993d-9b0f41dc415c", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "1e21dc9d-aba7-4358-8b42-493b11c91c31", 1, "Instructions Here", "f982c60c-937d-472f-a92f-38ba1b7b902b", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "5acadeb7-7d93-4cd2-8ec6-db36d7e940f5", 1, "Instructions Here", "f982c60c-937d-472f-a92f-38ba1b7b902b", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "9ef43de7-4897-42c0-99a3-cb4e0eade23d", 1, "Instructions Here", "f982c60c-937d-472f-a92f-38ba1b7b902b", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "71115d6c-0f00-47d3-9b63-94abf61ebce1", null, "f982c60c-937d-472f-a92f-38ba1b7b902b" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "e02889dd-7c48-4e86-822a-1b37ccb02bd0", "f982c60c-937d-472f-a92f-38ba1b7b902b", null });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "f982c60c-937d-472f-a92f-38ba1b7b902b", "71115d6c-0f00-47d3-9b63-94abf61ebce1", "e02889dd-7c48-4e86-822a-1b37ccb02bd0" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "1e21dc9d-aba7-4358-8b42-493b11c91c31", null, "9ef43de7-4897-42c0-99a3-cb4e0eade23d" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "5acadeb7-7d93-4cd2-8ec6-db36d7e940f5", "9ef43de7-4897-42c0-99a3-cb4e0eade23d", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "9ef43de7-4897-42c0-99a3-cb4e0eade23d", "1e21dc9d-aba7-4358-8b42-493b11c91c31", "5acadeb7-7d93-4cd2-8ec6-db36d7e940f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51bb534e-79c5-48b7-8340-b491a0e778db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dd437c2-15bd-4850-887b-62edc43d88c6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "46fbfafb-1f5a-4742-a584-4942fed5b5b9", "90fbb053-5bee-47f7-8623-0d85c32cc8c7" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "dd74a194-b2b5-49fe-a316-be04dd3f490e");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "1e21dc9d-aba7-4358-8b42-493b11c91c31");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "5acadeb7-7d93-4cd2-8ec6-db36d7e940f5");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "9ef43de7-4897-42c0-99a3-cb4e0eade23d");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "0f3345be-c57e-4d2a-a021-ee8bb4f983d3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "4ca6fbce-95c7-4dae-98b8-ada62dc357d7");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "547b5dbc-87aa-4949-8ba0-1902ad000b22");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "eeca3d56-8986-4102-ab33-e6b34315e29b");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "5ccc0afc-3ffd-4787-8df0-d34065983605");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "71115d6c-0f00-47d3-9b63-94abf61ebce1");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "e02889dd-7c48-4e86-822a-1b37ccb02bd0");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "f982c60c-937d-472f-a92f-38ba1b7b902b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46fbfafb-1f5a-4742-a584-4942fed5b5b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90fbb053-5bee-47f7-8623-0d85c32cc8c7");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "1e21dc9d-aba7-4358-8b42-493b11c91c31");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "5acadeb7-7d93-4cd2-8ec6-db36d7e940f5");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "9ef43de7-4897-42c0-99a3-cb4e0eade23d");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "71115d6c-0f00-47d3-9b63-94abf61ebce1");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "e02889dd-7c48-4e86-822a-1b37ccb02bd0");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "f982c60c-937d-472f-a92f-38ba1b7b902b");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "99c32534-ac3a-47f5-993d-9b0f41dc415c");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "df1ca4a2-568c-4a74-85e9-a031d89dc957");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23dc02ce-c57b-469d-a094-4553d335b4f5", "23dc02ce-c57b-469d-a094-4553d335b4f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87107a97-bba6-4c64-8b7b-03d49958eca1", "87107a97-bba6-4c64-8b7b-03d49958eca1", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff0eda17-7c93-4f5d-9888-806e5cc2ec37", "ff0eda17-7c93-4f5d-9888-806e5cc2ec37", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "b6dfd114-c8e2-4953-ae06-2f11bc51ce9d", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "bb31a196-9438-4868-902f-54a72c32b7f1", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "d866a919-d411-4243-afad-ac1960255dc3", "2i3" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "ef8c0f27-a7b2-4a9a-ac88-43c25fe4b7c2", "2i2" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "0fa30775-189f-4943-beef-1b6543c06806", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "78da7aea-37e5-49f7-bbc1-369c77c29e2d", "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "3ae3e88f-5fe8-42e7-a1ff-e81032ef9bfb", "78da7aea-37e5-49f7-bbc1-369c77c29e2d", "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "64ec4d5e-2e6b-4d46-863d-8a36185a5473", "78da7aea-37e5-49f7-bbc1-369c77c29e2d", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "1dbf8abf-404a-40b3-820f-9c80e511713a", "3ae3e88f-5fe8-42e7-a1ff-e81032ef9bfb", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "591a5c7c-710c-400e-b64c-3c52a7ae147c", "3ae3e88f-5fe8-42e7-a1ff-e81032ef9bfb", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "672c6cb2-aff6-4a23-ba1d-7974faad18fa", "3ae3e88f-5fe8-42e7-a1ff-e81032ef9bfb", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "0f7e84ed-8465-49c6-8092-9ff6642131b8", 1, "Instructions Here", "591a5c7c-710c-400e-b64c-3c52a7ae147c", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "53979db5-9c2b-4f5c-9ab5-c851fa714ae8", 1, "Instructions Here", "591a5c7c-710c-400e-b64c-3c52a7ae147c", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "5d618db4-e4d3-49a3-a2dc-51e6daa3bad5", 1, "Instructions Here", "591a5c7c-710c-400e-b64c-3c52a7ae147c", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "1dbf8abf-404a-40b3-820f-9c80e511713a", null, "591a5c7c-710c-400e-b64c-3c52a7ae147c" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "591a5c7c-710c-400e-b64c-3c52a7ae147c", "1dbf8abf-404a-40b3-820f-9c80e511713a", "672c6cb2-aff6-4a23-ba1d-7974faad18fa" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "672c6cb2-aff6-4a23-ba1d-7974faad18fa", "591a5c7c-710c-400e-b64c-3c52a7ae147c", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "0f7e84ed-8465-49c6-8092-9ff6642131b8", null, "53979db5-9c2b-4f5c-9ab5-c851fa714ae8" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "53979db5-9c2b-4f5c-9ab5-c851fa714ae8", "0f7e84ed-8465-49c6-8092-9ff6642131b8", "5d618db4-e4d3-49a3-a2dc-51e6daa3bad5" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "5d618db4-e4d3-49a3-a2dc-51e6daa3bad5", "53979db5-9c2b-4f5c-9ab5-c851fa714ae8", null });
        }
    }
}
