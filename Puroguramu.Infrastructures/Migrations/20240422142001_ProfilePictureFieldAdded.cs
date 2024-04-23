using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puroguramu.Infrastructures.Migrations
{
    public partial class ProfilePictureFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicturePath",
                table: "AspNetUsers",
                type: "BLOB",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ProfilePicturePath",
                table: "AspNetUsers");

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
    }
}
