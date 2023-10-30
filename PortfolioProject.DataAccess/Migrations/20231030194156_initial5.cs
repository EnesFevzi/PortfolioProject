using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "a8a3c90d-9d00-433e-8033-68229335e9d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "d26116a0-e3f3-4842-8b0c-790f0ce7058c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "ImageID", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf3b10d6-6c1f-41c2-a1e1-5bfd3f3ab072", "Enes Fevzi", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "Çiçekli", "AQAAAAEAACcQAAAAEEek5AxXR2E3VgAQ3p4Rl/MS1shl6GlSaxr1S3t0aXzmKdwN5TCKTl/oruLiLWtIUg==", "85cf53b8-a9fe-4d49-8350-dadfa4b67c0d" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                columns: new[] { "CreatedDate", "FileName", "FileType" },
                values: new object[] { new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7777), "user-images/default.jpg", "image/png" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                columns: new[] { "CreatedDate", "FileName", "FileType" },
                values: new object[] { new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7773), "project-images/defaultPortfolio.jpg", "image/jpeg" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 917, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 917, DateTimeKind.Local).AddTicks(259));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "20fdcdec-6fc9-416f-844e-ac3ccbb8ce88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "732bd815-753a-451c-8da3-4bcbc81737b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "ImageID", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78d5cabf-922f-4c23-a4be-d28d5aeadd2d", "Cem", new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Keskin", "AQAAAAEAACcQAAAAELmPv8I7Eni+dZgOeFNS30Z6XW+DX3hwoR5K6zGmW9kYC58FfJGOuTlizX/7h2lNug==", "9a49134b-bdbd-4955-998f-32a76ee8ccd6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, "86d662c2-abc3-4d5f-9b0a-92079bb4a48c", "admin@gmail.com", false, "Admin", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEG2pCsS8WLWeUoaZ4LMRBE0Gz5EPxIgUWjn5LlE4VYFyywCIanhqojEfvmcGjzKhbA==", "+905439999988", false, "2594acf8-77d3-404a-974a-048bba62048b", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                columns: new[] { "CreatedDate", "FileName", "FileType" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7405), "images/vstest", "png" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                columns: new[] { "CreatedDate", "FileName", "FileType" },
                values: new object[] { new DateTime(2023, 10, 30, 0, 37, 40, 187, DateTimeKind.Local).AddTicks(7401), "images/defaultPortfolio.jpg", "jpg" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 188, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 0, 37, 40, 188, DateTimeKind.Local).AddTicks(816));
        }
    }
}
