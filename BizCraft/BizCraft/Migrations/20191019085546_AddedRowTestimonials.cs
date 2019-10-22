using Microsoft.EntityFrameworkCore.Migrations;

namespace BizCraft.Migrations
{
    public partial class AddedRowTestimonials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Image", "SubTitle", "Title" },
                values: new object[] { 3, "testimonial3.jpg", "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", "Taline Lucine<span>Sales Manager</span>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
