using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1132FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class UnifyCommitteeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181700,
                column: "PhotoUrl",
                value: "Spongebob.png");

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181701,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "SquidWard", "Squidward.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181702,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "Sandy", "Sandy.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181703,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "Patrick", "Patrick.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181704,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "Plankton", "Plankton.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181705,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "Mr_Krab", "Krab.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181700,
                column: "PhotoUrl",
                value: "~/Images/CommitteeCard/Spongebob.png");

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181701,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "@SquidWard", "~/Images/CommitteeCard/Squidward.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181702,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "@Sandy", "/Images/CommitteeCard/Sandy.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181703,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "@Patrick", "/Images/CommitteeCard/Patrick.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181704,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "@Plankton", "~/Images/CommitteeCard/Plankton.png" });

            migrationBuilder.UpdateData(
                table: "Table_s1121768_CommitteeMembers",
                keyColumn: "CommitteeId",
                keyValue: 1181705,
                columns: new[] { "IG_Account", "PhotoUrl" },
                values: new object[] { "@Mr_Krab", "~/Images/CommitteeCard/Krab.png" });
        }
    }
}
