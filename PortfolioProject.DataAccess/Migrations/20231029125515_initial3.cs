using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "b8376b1b-0277-4264-b6a7-50a15db13fcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "af4ab029-af7b-4f60-bc35-3969c3dfa1d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "939eb743-c55b-4372-9905-08d4ea52fdda", "AQAAAAEAACcQAAAAENXr1uNuzAeg+MVjmrvpYXxAhGJAM5L+Wdemq+ejg2VrDhT6l6JIG6fCKTE+yUlN+w==", "43b0a1d4-3623-4640-8330-67d7560af70d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "736fc84a-f4dc-4c23-9828-f9daa9681034", "AQAAAAEAACcQAAAAEFctqzMsiQfnA9nsEvnsDsdVB6EDoknF8k5VZnM0K84isu4o2q40uYiulzSaTs4I3Q==", "3de13840-2c19-4190-a08b-ad2f4b24d48c" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 15, 55, 14, 868, DateTimeKind.Local).AddTicks(8726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Portfolios");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "76a69b10-42d7-4d40-bca6-2a20ea4d37cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "42c7856e-c4d7-4899-9a35-62c3c2a61913");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4ee6dad-bd57-439f-88ff-e59661adaae8", "AQAAAAEAACcQAAAAEEx5Xt/wmSvu4GRKVgmA838k8LcxBg0Lw56rFrrCoO5IYMaaYQeoMTIkPTw1je4tTw==", "11a1e9a2-2a80-4b21-b7fe-49327731ef62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d927fa6-0f2c-46d3-9c2e-a36cb927cd89", "AQAAAAEAACcQAAAAEFOrj3xzN4LTDyA+8iKWg9TSQK2/Viz+x+bQPAprTHSmmCPKGUr4MRScPnUnw2ZATA==", "b3f06c82-c083-4f8b-9fb3-182b8a7ea6cc" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 29, 14, 59, 27, 168, DateTimeKind.Local).AddTicks(5079));
        }
    }
}
