using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    public partial class initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ImageID",
                table: "Abouts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "047e99a7-3082-48bc-abe5-777b13c7dff6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "89d80823-8c8e-447b-b9ea-6ad23ca6b911");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfe26b79-61f1-4351-b190-a560101229ae", "AQAAAAEAACcQAAAAEAbv2zEHp3/EhbMEjWWo+PFVGN8p5dwfy6h59/w92LtaJgiwr3Xg7WahX+KApMXdzQ==", "efaefff6-e4f7-4e2d-8a2a-19cd4c84903d" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 31, 1, 3, 46, 381, DateTimeKind.Local).AddTicks(7907));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ImageID",
                table: "Abouts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 30, 23, 2, 55, 823, DateTimeKind.Local).AddTicks(5250));

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
    }
}
