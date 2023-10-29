using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    PortfolioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProjectURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.PortfolioID);
                    table.ForeignKey(
                        name: "FK_Portfolios_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Portfolios_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ImageID");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_ImageID",
                table: "Portfolios",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_UserID",
                table: "Portfolios",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Projects_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ImageID");
                });

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "AboutID",
                keyValue: new Guid("3f3eef04-efad-4615-b2e3-8fe2d8e5c1a7"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("343f8370-28d4-4ade-91df-7965041b98f1"),
                column: "ConcurrencyStamp",
                value: "96d79086-31f8-4ad1-aea6-60cec2d47bf7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0a0b477-42aa-47fd-9e01-a81da466848d"),
                column: "ConcurrencyStamp",
                value: "a7f6f71e-896d-4c80-ac6c-6a5a21ac5dd4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1390a89-9259-42d7-addf-895997d85842", "AQAAAAEAACcQAAAAEHK/OeKS4nwFTIYwzoY2HFq70NN6W08Wj+F1KFzhaCoO1ACpGNgu1hsawSsk0Pok/g==", "79b44b14-7b35-454a-8f99-5e3dca02ba86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c4e2399-94c1-43e5-b458-c7c029512bd8", "AQAAAAEAACcQAAAAEL5l6E9A3LUyATg0uwBwo0uEBGZ+6XfT6K1zStAp+/MGi9we7r28tKwTtqtLQ9m9uA==", "b8884a22-24e3-4785-827d-2f53339f1b57" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("36719172-eaf3-4963-ab41-d88aac522f76"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationID",
                keyValue: new Guid("d2fbacfa-415b-4c5a-b20c-efe531c75d61"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("112bd5a2-be97-4648-a766-b78d3f22b800"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceID",
                keyValue: new Guid("c0cae11a-f46b-4c89-b9ca-b80ce5152f22"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 611, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("359e96f1-42f4-42ac-8521-df585bff9086"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 612, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillID",
                keyValue: new Guid("62d9f2f3-9390-4cf8-a67a-92d98c71a2c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 10, 28, 12, 25, 7, 612, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ImageID",
                table: "Projects",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserID",
                table: "Projects",
                column: "UserID");
        }
    }
}
