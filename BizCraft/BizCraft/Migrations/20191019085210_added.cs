using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BizCraft.Migrations
{
    public partial class added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    Icon = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutInfoImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutInfoImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwesomeWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 250, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwesomeWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Price = table.Column<string>(maxLength: 100, nullable: false),
                    Bandwith = table.Column<string>(maxLength: 100, nullable: false),
                    AdWords = table.Column<string>(maxLength: 100, nullable: false),
                    Hosting = table.Column<string>(maxLength: 100, nullable: false),
                    Cart = table.Column<string>(maxLength: 100, nullable: false),
                    Support = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProvides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProvides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    ButtonOne = table.Column<string>(nullable: true),
                    ButtonTwo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 200, nullable: false),
                    Facebook = table.Column<string>(maxLength: 100, nullable: false),
                    Twitter = table.Column<string>(maxLength: 100, nullable: false),
                    Google = table.Column<string>(maxLength: 100, nullable: false),
                    Linkedin = table.Column<string>(maxLength: 100, nullable: false),
                    Dribble = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Title = table.Column<string>(maxLength: 1000, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutCompanies",
                columns: new[] { "Id", "Icon", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 1, "fa fa-bicycle", "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", "Tons of Features" },
                    { 2, "fa fa-diamond", "Proin gravida nibh vel velit auctor Aenean sollicitudin adipisicing", "PowerPack Theme" },
                    { 3, "fa fa-street-view", "Simply dummy text and typesettings industry has been the industry", "Day Night Support" }
                });

            migrationBuilder.InsertData(
                table: "AboutInfoImages",
                columns: new[] { "Id", "Image" },
                values: new object[] { 1, "image-block-bg.jpg" });

            migrationBuilder.InsertData(
                table: "AwesomeWorks",
                columns: new[] { "Id", "Image", "Title" },
                values: new object[,]
                {
                    { 8, "portfolio8.jpg", "Amazing Keyboard" },
                    { 7, "portfolio7.jpg", "Light Carpet" },
                    { 5, "portfolio5.jpg", "Fashion Brand" },
                    { 6, "portfolio6.jpg", "The Insidage" },
                    { 3, "portfolio3.jpg", "Your Business" },
                    { 2, "portfolio2.jpg", "Easy to Lanunch" },
                    { 1, "portfolio1.jpg", "Startup Businesse!" },
                    { 4, "portfolio4.jpg", "Prego Match" }
                });

            migrationBuilder.InsertData(
                table: "Counters",
                columns: new[] { "Id", "Count", "Title" },
                values: new object[,]
                {
                    { 1, 1200, "Clients" },
                    { 2, 1277, "Item Sold" },
                    { 3, 869, "Projects" },
                    { 4, 76, "Awwards" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Icon", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 7, "fa fa-whatsapp", "Bras urna felis accumsan at ultrde cesid posuere masa socis nautoque penat", "Free Lifetime Updates" },
                    { 9, "fa fa-diamond", "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", "24/7 Live Support" },
                    { 8, "fa fa-recycle", "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", "Endless Possibilites" },
                    { 6, "fa fa-pagelines", "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", "Light wight Performance" },
                    { 5, "fa fa-desktop", "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", "Responsive Layout" },
                    { 4, "fa fa-newspaper-o", "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", "Multipurpose Concept" },
                    { 3, "fa fa-film", "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", "Parallax Section" },
                    { 2, "fa fa-codepen", "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", "Useful Shortcodes" },
                    { 1, "fa fa-heart-o", "Bras urna felis accumsan at ultrde cesid posuere masa socis nautoque penat", "Clean Modern Design" }
                });

            migrationBuilder.InsertData(
                table: "Pricings",
                columns: new[] { "Id", "AdWords", "Bandwith", "Cart", "Hosting", "Price", "Support", "Title" },
                values: new object[,]
                {
                    { 1, "$100 Google AdWords", "100GB Monthly Bandwidth", "SSL Shopping Cart", "100 Domain Hosting", "<sup class='currency'>$</sup><strong>49</strong><sub>.99</sub>", "24/7 Live Support", "Basic <small>Monthly plan</small>" },
                    { 2, "$100 Google AdWords", "100GB Monthly Bandwidth", "SSL Shopping Cart", "100 Domain Hosting", "<sup class='currency'>$</sup><strong>99</strong><sub>.99</sub>", "24/7 Live Support", "Standared <small>Monthly plan</small>" },
                    { 3, "$100 Google AdWords", "100GB Monthly Bandwidth", "SSL Shopping Cart", "100 Domain Hosting", "<sup class='currency'>$</sup><strong>149</strong><sub>.99</sub>", "24/7 Live Support", "Professional <small>Monthly plan</small>" },
                    { 4, "$100 Google AdWords", "100GB Monthly Bandwidth", "SSL Shopping Cart", "$100 Google AdWords", "<sup class='currency'>$</sup><strong>399</strong><sub>.99</sub>", "24/7 Live Support", "Premium <small>Monthly plan</small>" }
                });

            migrationBuilder.InsertData(
                table: "ServiceProvides",
                columns: new[] { "Id", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 4, "We design beautiful modern engaging websites that always latest responsive technologies.", "Design for Startups" },
                    { 3, "Neutra Thundercats craft beer, listicle meggings bicycle rights 90's XOXO beard cardiga", "eCommerce Websites" },
                    { 1, "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua polaroid befor", "Web Design" },
                    { 2, "Food truck master cleanse mixtape minim Portland, cardigan stumptown chambray swag", "Apps Development" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ButtonOne", "ButtonTwo", "Image", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 1, "Start Now", "Learn More", "bg1.jpg", "We Making Difference To Great Things Possible", "Need To Invent The Future!" },
                    { 2, null, "Take a Tour", "bg2.jpg", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. In consequatur cumque natus!", "How Big Can You Dream?" },
                    { 3, "Start", "Learn More", "bg3.jpg", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. In consequatur cumque natus!", "Your Challenge is Our Progress" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Dribble", "Facebook", "Google", "Image", "Linkedin", "SubTitle", "Title", "Twitter" },
                values: new object[,]
                {
                    { 1, "fa fa-dribbble", "fa fa-facebook", "fa fa-google-plus", "team1.jpg", "fa fa-linkedin", "Web Designer", "Vosgi Varduhi", "fa fa-twitter" },
                    { 2, "fa fa-dribbble", "fa fa-facebook", "fa fa-google-plus", "team2.jpg", "fa fa-linkedin", "Web Designer", "Robert Aleska", "fa fa-twitter" },
                    { 3, "fa fa-dribbble", "fa fa-facebook", "fa fa-google-plus", "team3.jpg", "fa fa-linkedin", "Web Designer", "Taline Voski", "fa fa-twitter" },
                    { 4, "fa fa-dribbble", "fa fa-facebook", "fa fa-google-plus", "team4.jpg", "fa fa-linkedin", "Web Designer", "Alban Spencer", "fa fa-twitter" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Image", "SubTitle", "Title" },
                values: new object[,]
                {
                    { 1, "testimonial1.jpg", "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", "Sarah Arevik<span>Chief Executive</span>" },
                    { 2, "testimonial2.jpg", "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", "Narek Bedros<span>Sr. Manager</span>" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCompanies");

            migrationBuilder.DropTable(
                name: "AboutInfoImages");

            migrationBuilder.DropTable(
                name: "AwesomeWorks");

            migrationBuilder.DropTable(
                name: "Counters");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "ServiceProvides");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
