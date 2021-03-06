using Microsoft.EntityFrameworkCore.Migrations;

namespace Personelinformation.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailInformations",
                columns: table => new
                {
                    DetailInformationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FatherName = table.Column<string>(type: "TEXT", nullable: true),
                    MotherName = table.Column<string>(type: "TEXT", nullable: true),
                    BirthPlace = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInformations", x => x.DetailInformationID);
                });

            migrationBuilder.CreateTable(
                name: "PersonelInformations",
                columns: table => new
                {
                    PersonelInformationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CiltNo = table.Column<int>(type: "INTEGER", nullable: false),
                    AileSiraNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelInformations", x => x.PersonelInformationID);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    InformationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonelName = table.Column<string>(type: "TEXT", nullable: true),
                    PersonelSurname = table.Column<string>(type: "TEXT", nullable: true),
                    DetailInformationID = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonelInformationID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.InformationID);
                    table.ForeignKey(
                        name: "FK_Informations_DetailInformations_DetailInformationID",
                        column: x => x.DetailInformationID,
                        principalTable: "DetailInformations",
                        principalColumn: "DetailInformationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Informations_PersonelInformations_PersonelInformationID",
                        column: x => x.PersonelInformationID,
                        principalTable: "PersonelInformations",
                        principalColumn: "PersonelInformationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DetailInformations",
                columns: new[] { "DetailInformationID", "BirthPlace", "FatherName", "MotherName" },
                values: new object[] { 1, "Kilis", "Mehmet", "Ayşe" });

            migrationBuilder.InsertData(
                table: "DetailInformations",
                columns: new[] { "DetailInformationID", "BirthPlace", "FatherName", "MotherName" },
                values: new object[] { 2, "İstanbul", "Ahmet", "Aslı" });

            migrationBuilder.InsertData(
                table: "DetailInformations",
                columns: new[] { "DetailInformationID", "BirthPlace", "FatherName", "MotherName" },
                values: new object[] { 3, "Rize", "Hasan", "Müge" });

            migrationBuilder.InsertData(
                table: "PersonelInformations",
                columns: new[] { "PersonelInformationID", "AileSiraNo", "CiltNo", "Title" },
                values: new object[] { 1, 302, 13, "Mühendis" });

            migrationBuilder.InsertData(
                table: "PersonelInformations",
                columns: new[] { "PersonelInformationID", "AileSiraNo", "CiltNo", "Title" },
                values: new object[] { 2, 407, 25, "Yazılımcı" });

            migrationBuilder.InsertData(
                table: "PersonelInformations",
                columns: new[] { "PersonelInformationID", "AileSiraNo", "CiltNo", "Title" },
                values: new object[] { 3, 123, 32, "Satış Danışmanı" });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "InformationID", "DetailInformationID", "PersonelInformationID", "PersonelName", "PersonelSurname" },
                values: new object[] { 1, 1, 1, "Murat", "Kuşcan" });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "InformationID", "DetailInformationID", "PersonelInformationID", "PersonelName", "PersonelSurname" },
                values: new object[] { 2, 2, 2, "Adnan", "Derkan" });

            migrationBuilder.InsertData(
                table: "Informations",
                columns: new[] { "InformationID", "DetailInformationID", "PersonelInformationID", "PersonelName", "PersonelSurname" },
                values: new object[] { 3, 3, 3, "Esra", "Kurt" });

            migrationBuilder.CreateIndex(
                name: "IX_Informations_DetailInformationID",
                table: "Informations",
                column: "DetailInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Informations_PersonelInformationID",
                table: "Informations",
                column: "PersonelInformationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "DetailInformations");

            migrationBuilder.DropTable(
                name: "PersonelInformations");
        }
    }
}
