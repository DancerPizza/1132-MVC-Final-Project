using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _1132FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_s1121768_CommitteeMembers",
                columns: table => new
                {
                    CommitteeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IG_Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_s1121768_CommitteeMembers", x => x.CommitteeId);
                });

            migrationBuilder.CreateTable(
                name: "Table_s1121768_NewMembers",
                columns: table => new
                {
                    StuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IG_Account = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_s1121768_NewMembers", x => x.StuId);
                });

            migrationBuilder.InsertData(
                table: "Table_s1121768_CommitteeMembers",
                columns: new[] { "CommitteeId", "IG_Account", "NickName", "PhotoUrl", "Position", "Section" },
                values: new object[,]
                {
                    { 1181700, "dancer_pizza", "Pizza", "~/Images/CommitteeCard/Spongebob.png", "教學長", "Locking" },
                    { 1181701, "@SquidWard", "章魚哥", "~/Images/CommitteeCard/Squidward.png", "社長", "Locking" },
                    { 1181702, "@Sandy", "珊迪", "/Images/CommitteeCard/Sandy.png", "教學長", "Jazz" },
                    { 1181703, "@Patrick", "派大星", "/Images/CommitteeCard/Patrick.png", "活動長", "Popping" },
                    { 1181704, "@Plankton", "皮老闆", "~/Images/CommitteeCard/Plankton.png", "副社長", "Breaking" },
                    { 1181705, "@Mr_Krab", "蟹老闆", "~/Images/CommitteeCard/Krab.png", "總務長", "hiphop" }
                });

            migrationBuilder.InsertData(
                table: "Table_s1121768_NewMembers",
                columns: new[] { "StuId", "Department", "IG_Account", "Name", "NickName", "RegisteredAt", "Section" },
                values: new object[,]
                {
                    { "1191700", "資管系", "@Wang_1700", "小王", "Alex", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Locking" },
                    { "1191701", "資工系", "@Lee_1700", "小李", "Bob", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Popping" },
                    { "1191702", "企管系", "@Char_1700", "查理", "Charlie", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_s1121768_CommitteeMembers");

            migrationBuilder.DropTable(
                name: "Table_s1121768_NewMembers");
        }
    }
}
