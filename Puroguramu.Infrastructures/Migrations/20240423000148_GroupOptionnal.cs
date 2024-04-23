using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class GroupOptionnal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "669c040c-47d2-40f2-9d50-b560404e1145");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90c88d5-8acc-4977-ad9f-e47d76dc8658");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed767fcf-49dd-4f34-9cc2-c112af5e6164");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "62ba95db-9de5-4b19-9a35-ad972482d25b");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "82ba865a-812b-4834-b585-bb18382e9bdb");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "dff28bf6-8188-4b4b-9c67-1a0f81d058cb");

            migrationBuilder.DeleteData(
                table: "ExerciseOrders",
                keyColumn: "ExerciseId",
                keyValue: "e70a0d27-ae5b-4096-88a1-4cac7b1650e3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "36fc2624-7ff0-4f01-8484-37a08ad27fa3");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "89d440dc-bbf5-4df5-8dc2-5758d4ed316c");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "b3996eae-4d06-46b7-9059-7593e4bd9bb4");

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: "dadecd3a-5556-4b65-b4ce-a5733d284177");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "3dff94fc-598a-468d-869c-5cabd355d8a6");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "127a94d4-0231-4b5f-8539-9729144cda9a");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "7c2228ff-17b7-4b72-bf29-75994c762a11");

            migrationBuilder.DeleteData(
                table: "LessonOrders",
                keyColumn: "LessonId",
                keyValue: "7fad8adf-1530-4b78-88be-ce59d06809d0");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "82ba865a-812b-4834-b585-bb18382e9bdb");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "dff28bf6-8188-4b4b-9c67-1a0f81d058cb");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "e70a0d27-ae5b-4096-88a1-4cac7b1650e3");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "7c2228ff-17b7-4b72-bf29-75994c762a11");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "7fad8adf-1530-4b78-88be-ce59d06809d0");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: "127a94d4-0231-4b5f-8539-9729144cda9a");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: "36e702d1-6eeb-4511-86c2-359b1bf3790d");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "a776c7a5-9086-4675-a81e-8d45eb4ba59b");

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers");

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

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "669c040c-47d2-40f2-9d50-b560404e1145", "669c040c-47d2-40f2-9d50-b560404e1145", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b90c88d5-8acc-4977-ad9f-e47d76dc8658", "b90c88d5-8acc-4977-ad9f-e47d76dc8658", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed767fcf-49dd-4f34-9cc2-c112af5e6164", "ed767fcf-49dd-4f34-9cc2-c112af5e6164", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "36fc2624-7ff0-4f01-8484-37a08ad27fa3", "2i1" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "89d440dc-bbf5-4df5-8dc2-5758d4ed316c", "2i4" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "b3996eae-4d06-46b7-9059-7593e4bd9bb4", "2i2" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { "dadecd3a-5556-4b65-b4ce-a5733d284177", "2i3" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "3dff94fc-598a-468d-869c-5cabd355d8a6", "Java" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { "a776c7a5-9086-4675-a81e-8d45eb4ba59b", "C#" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "36e702d1-6eeb-4511-86c2-359b1bf3790d", "a776c7a5-9086-4675-a81e-8d45eb4ba59b", "Beginners" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "LanguageId", "Title" },
                values: new object[] { "62ba95db-9de5-4b19-9a35-ad972482d25b", "a776c7a5-9086-4675-a81e-8d45eb4ba59b", "Amateurs" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "127a94d4-0231-4b5f-8539-9729144cda9a", "36e702d1-6eeb-4511-86c2-359b1bf3790d", "", true, "Functions" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "7c2228ff-17b7-4b72-bf29-75994c762a11", "36e702d1-6eeb-4511-86c2-359b1bf3790d", "", true, "Classes" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CourseId", "Description", "IsVisible", "Title" },
                values: new object[] { "7fad8adf-1530-4b78-88be-ce59d06809d0", "36e702d1-6eeb-4511-86c2-359b1bf3790d", "", true, "Variables" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "82ba865a-812b-4834-b585-bb18382e9bdb", 1, "Instructions Here", "127a94d4-0231-4b5f-8539-9729144cda9a", "Skeleton Here", "HelloWorld" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "dff28bf6-8188-4b4b-9c67-1a0f81d058cb", 1, "Instructions Here", "127a94d4-0231-4b5f-8539-9729144cda9a", "Skeleton Here", "Obi-Wan" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "DifficultyLevel", "Instructions", "LessonId", "Skeleton", "Title" },
                values: new object[] { "e70a0d27-ae5b-4096-88a1-4cac7b1650e3", 1, "Instructions Here", "127a94d4-0231-4b5f-8539-9729144cda9a", "Skeleton Here", "HelloThere" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "127a94d4-0231-4b5f-8539-9729144cda9a", "7c2228ff-17b7-4b72-bf29-75994c762a11", "7fad8adf-1530-4b78-88be-ce59d06809d0" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "7c2228ff-17b7-4b72-bf29-75994c762a11", null, "127a94d4-0231-4b5f-8539-9729144cda9a" });

            migrationBuilder.InsertData(
                table: "LessonOrders",
                columns: new[] { "LessonId", "LessonAfterId", "LessonBeforeId" },
                values: new object[] { "7fad8adf-1530-4b78-88be-ce59d06809d0", "127a94d4-0231-4b5f-8539-9729144cda9a", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "82ba865a-812b-4834-b585-bb18382e9bdb", "e70a0d27-ae5b-4096-88a1-4cac7b1650e3", null });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "dff28bf6-8188-4b4b-9c67-1a0f81d058cb", null, "e70a0d27-ae5b-4096-88a1-4cac7b1650e3" });

            migrationBuilder.InsertData(
                table: "ExerciseOrders",
                columns: new[] { "ExerciseId", "ExerciseAfterId", "ExerciseBeforeId" },
                values: new object[] { "e70a0d27-ae5b-4096-88a1-4cac7b1650e3", "dff28bf6-8188-4b4b-9c67-1a0f81d058cb", "82ba865a-812b-4834-b585-bb18382e9bdb" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Groups_GroupId",
                table: "AspNetUsers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
