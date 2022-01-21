using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
  public partial class SeedData : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.InsertData(
          table: "Animals",
          columns: new[] { "AnimalId", "Age", "Description", "Gender", "Name", "Species" },
          values: new object[,]
          {
                    { 1, 13, "sweet old granny", "Female", "Doggy", "Dog" },
                    { 2, 8, "people pleaser", "Male", "Dax", "Dog" },
                    { 3, 4, "big teddy bear", "Male", "Bruce", "Dog" },
                    { 4, 6, "explorer", "Female", "Kiki", "Cat" },
                    { 5, 7, "hates crowds", "Female", "Pepper", "Cat" },
                    { 6, 6, "super friendly", "Female", "Ramona", "Cat" }
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 1);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 2);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 3);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 4);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 5);

      migrationBuilder.DeleteData(
          table: "Animals",
          keyColumn: "AnimalId",
          keyValue: 6);
    }
  }
}
