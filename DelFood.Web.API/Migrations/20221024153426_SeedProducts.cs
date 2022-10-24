using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DelFood.Web.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Some description about greate food!", "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Shrimp.jpg", "Shrimp in tom-yam sauce", 14.99 },
                    { 2, "Salads", "Some description about tasty food!", "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Tuna salad.jpg", "Tuna Salad", 11.99 },
                    { 3, "Dessert", "Some description about tasty food!", "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Sweet pie.jpg", "Sweet Pie", 10.99 },
                    { 4, "Entree", "Some description about tasty food!", "E:\\Work\\Delivery-Food-API-Application\\DelFood.Web\\wwwroot\\Images\\Steak.jpg", "Striploin steake with Dor blue cheese butter", 19.989999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
