using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Abouts",
                newName: "Linkedin");

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                columns: new[] { "CreatedDate", "GitHub", "Linkedin" },
                values: new object[] { new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(5250), "https://github.com/EnesFevzi", "https://www.linkedin.com/in/enes-fevzi-cicekli" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "98cba5c9-4f03-444c-a94c-b8b15e4e659e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "7ce5797a-79bd-4b23-9678-cc3a1f13ec38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "668abf6c-2a27-427e-8130-ad70dc182748", "AQAAAAEAACcQAAAAEHwkPAXh9g4ueTzDSGnqWTHGvU05P0xwyUCztbxGKtB6M0FIlM63HABr4e0k7rHgYA==", "24451964-0631-4ab8-b8d0-bcb29edd46ed" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(8473));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Linkedin",
                table: "Abouts",
                newName: "Website");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                columns: new[] { "CreatedDate", "Website" },
                values: new object[] { new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(6734), "enesfevzicicekli.com.tr" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf3b10d6-6c1f-41c2-a1e1-5bfd3f3ab072", "AQAAAAEAACcQAAAAEEek5AxXR2E3VgAQ3p4Rl/MS1shl6GlSaxr1S3t0aXzmKdwN5TCKTl/oruLiLWtIUg==", "85cf53b8-a9fe-4d49-8350-dadfa4b67c0d" });

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
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 22, 41, 55, 916, DateTimeKind.Local).AddTicks(7773));

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
    }
}
