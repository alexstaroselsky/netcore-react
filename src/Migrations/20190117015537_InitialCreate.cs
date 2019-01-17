using Microsoft.EntityFrameworkCore.Migrations;

namespace NutritionData.Backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    DescriptionId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    FoodGroup = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    CommercialName = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    NitrogenToProteinConversionFactor = table.Column<decimal>(nullable: false),
                    CarbohydrateFactor = table.Column<decimal>(nullable: false),
                    FatFactor = table.Column<decimal>(nullable: false),
                    ProteinFactor = table.Column<decimal>(nullable: false),
                    RefusePercent = table.Column<string>(nullable: true),
                    RefuseDescription = table.Column<string>(nullable: true),
                    DatabaseSource = table.Column<string>(nullable: true),
                    ReportingUnit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.DescriptionId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<string>(nullable: false),
                    DescriptionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Footnote",
                columns: table => new
                {
                    FootnoteId = table.Column<string>(nullable: false),
                    NDBNumber = table.Column<string>(nullable: false),
                    SequenceNumber = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    NutrientNumber = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: false),
                    FoodId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footnote", x => x.FootnoteId);
                    table.ForeignKey(
                        name: "FK_Footnote_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nutrient",
                columns: table => new
                {
                    NutrientId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    FoodId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrient", x => x.NutrientId);
                    table.ForeignKey(
                        name: "FK_Nutrient_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    SourceId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Authors = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    Issue = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    StartPage = table.Column<string>(nullable: true),
                    EndPage = table.Column<string>(nullable: true),
                    FoodId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.SourceId);
                    table.ForeignKey(
                        name: "FK_Source_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Measure",
                columns: table => new
                {
                    MeasureId = table.Column<string>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Equivalent = table.Column<decimal>(nullable: false),
                    EUnit = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Value = table.Column<decimal>(nullable: false),
                    NutrientId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measure", x => x.MeasureId);
                    table.ForeignKey(
                        name: "FK_Measure_Nutrient_NutrientId",
                        column: x => x.NutrientId,
                        principalTable: "Nutrient",
                        principalColumn: "NutrientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_DescriptionId",
                table: "Foods",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Footnote_FoodId",
                table: "Footnote",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Measure_NutrientId",
                table: "Measure",
                column: "NutrientId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrient_FoodId",
                table: "Nutrient",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Source_FoodId",
                table: "Source",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footnote");

            migrationBuilder.DropTable(
                name: "Measure");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Nutrient");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Description");
        }
    }
}
