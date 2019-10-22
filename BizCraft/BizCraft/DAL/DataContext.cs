using BizCraft.Models;
using BizCraft.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizCraft.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ServiceProvide> ServiceProvides { get; set; }
        public DbSet<AwesomeWork> AwesomeWorks { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<AboutInfoImage> AboutInfoImages { get; set; }
        public DbSet<AboutCompany> AboutCompanies { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasData(
                new Slider { Id = 1, Image = "bg1.jpg", Title = "Need To Invent The Future!", SubTitle = "We Making Difference To Great Things Possible", ButtonOne = "Start Now", ButtonTwo = "Learn More" },
                new Slider { Id = 2, Image = "bg2.jpg", Title = "How Big Can You Dream?", SubTitle = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. In consequatur cumque natus!", ButtonTwo = "Take a Tour" },
                new Slider { Id = 3, Image = "bg3.jpg", Title = "Your Challenge is Our Progress", SubTitle = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. In consequatur cumque natus!", ButtonOne = "Start", ButtonTwo = "Learn More" }
                );
            modelBuilder.Entity<ServiceProvide>().HasData(
                new ServiceProvide { Id = 1, Title = "Web Design", SubTitle = "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua polaroid befor" },
                new ServiceProvide { Id = 2,  Title = "Apps Development", SubTitle = "Food truck master cleanse mixtape minim Portland, cardigan stumptown chambray swag" },
                new ServiceProvide { Id = 3,  Title = "eCommerce Websites", SubTitle = "Neutra Thundercats craft beer, listicle meggings bicycle rights 90's XOXO beard cardiga" },
                new ServiceProvide { Id = 4, Title = "Design for Startups", SubTitle = "We design beautiful modern engaging websites that always latest responsive technologies." }
                );
            modelBuilder.Entity<AwesomeWork>().HasData(
               new AwesomeWork { Id = 1, Image = "portfolio1.jpg", Title = "Startup Businesse!" },
               new AwesomeWork { Id = 2, Image = "portfolio2.jpg", Title = "Easy to Lanunch" },
               new AwesomeWork { Id = 3, Image = "portfolio3.jpg", Title = "Your Business" },
               new AwesomeWork { Id = 4, Image = "portfolio4.jpg", Title = "Prego Match" },
               new AwesomeWork { Id = 5, Image = "portfolio5.jpg", Title = "Fashion Brand" },
               new AwesomeWork { Id = 6, Image = "portfolio6.jpg", Title = "The Insidage" },
               new AwesomeWork { Id = 7, Image = "portfolio7.jpg", Title = "Light Carpet" },
               new AwesomeWork { Id = 8, Image = "portfolio8.jpg", Title = "Amazing Keyboard" }
               );
            modelBuilder.Entity<Counter>().HasData(
                new Counter { Id = 1, Count = 1200, Title = "Clients" },
                new Counter { Id = 2, Count = 1277, Title = "Item Sold" },
                new Counter { Id = 3, Count = 869, Title = "Projects" },
                new Counter { Id = 4, Count = 76, Title = "Awwards" }
                );
            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = 1, Title = "Clean Modern Design", SubTitle = "Bras urna felis accumsan at ultrde cesid posuere masa socis nautoque penat", Icon = "fa fa-heart-o" },
                new Feature { Id = 2, Title = "Useful Shortcodes", SubTitle = "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", Icon = "fa fa-codepen" },
                new Feature { Id = 3, Title = "Parallax Section", SubTitle = "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", Icon = "fa fa-film" },
                new Feature { Id = 4, Title = "Multipurpose Concept", SubTitle = "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", Icon = "fa fa-newspaper-o" },
                new Feature { Id = 5, Title = "Responsive Layout", SubTitle = "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", Icon = "fa fa-desktop" },
                new Feature { Id = 6, Title = "Light wight Performance", SubTitle = "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", Icon = "fa fa-pagelines" },
                new Feature { Id = 7, Title = "Free Lifetime Updates", SubTitle = "Bras urna felis accumsan at ultrde cesid posuere masa socis nautoque penat", Icon = "fa fa-whatsapp" },
                new Feature { Id = 8, Title = "Endless Possibilites", SubTitle = "High Life narwhal, banh mi PBR single-origin coffee Odd Future actually aliqua", Icon = "fa fa-recycle" },
                new Feature { Id = 9, Title = "24/7 Live Support", SubTitle = "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", Icon = "fa fa-diamond" }
                );
            modelBuilder.Entity<AboutInfoImage>().HasData(
                new AboutInfoImage { Id = 1, Image = "image-block-bg.jpg" }
                );

            modelBuilder.Entity<AboutCompany>().HasData(
                new AboutCompany { Id = 1, Title = "Tons of Features", SubTitle = "Consectetur adipisicing elit sed do eiusmod tempor incididunt ut", Icon = "fa fa-bicycle" },
                new AboutCompany { Id = 2, Title = "PowerPack Theme", SubTitle = "Proin gravida nibh vel velit auctor Aenean sollicitudin adipisicing", Icon = "fa fa-diamond" },
                new AboutCompany { Id = 3, Title = "Day Night Support", SubTitle = "Simply dummy text and typesettings industry has been the industry", Icon = "fa fa-street-view" }
                );
            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Image = "team1.jpg", Title = "Vosgi Varduhi", SubTitle = "Web Designer", Facebook = "fa fa-facebook", Twitter = "fa fa-twitter", Google = "fa fa-google-plus", Linkedin = "fa fa-linkedin", Dribble = "fa fa-dribbble" },
                new Team { Id = 2, Image = "team2.jpg", Title = "Robert Aleska", SubTitle = "Web Designer", Facebook = "fa fa-facebook", Twitter = "fa fa-twitter", Google = "fa fa-google-plus", Linkedin = "fa fa-linkedin", Dribble = "fa fa-dribbble" },
                new Team { Id = 3, Image = "team3.jpg", Title = "Taline Voski", SubTitle = "Web Designer", Facebook = "fa fa-facebook", Twitter = "fa fa-twitter", Google = "fa fa-google-plus", Linkedin = "fa fa-linkedin", Dribble = "fa fa-dribbble" },
                new Team { Id = 4, Image = "team4.jpg", Title = "Alban Spencer", SubTitle = "Web Designer", Facebook = "fa fa-facebook", Twitter = "fa fa-twitter", Google = "fa fa-google-plus", Linkedin = "fa fa-linkedin", Dribble = "fa fa-dribbble" }

                );
            modelBuilder.Entity<Pricing>().HasData(
                new Pricing { Id = 1, Title = "Basic <small>Monthly plan</small>", Price = "<sup class='currency'>$</sup><strong>49</strong><sub>.99</sub>", Bandwith = "100GB Monthly Bandwidth", AdWords = "$100 Google AdWords", Hosting = "100 Domain Hosting", Cart = "SSL Shopping Cart", Support = "24/7 Live Support" },
                new Pricing { Id = 2, Title = "Standared <small>Monthly plan</small>", Price = "<sup class='currency'>$</sup><strong>99</strong><sub>.99</sub>", Bandwith = "100GB Monthly Bandwidth", AdWords = "$100 Google AdWords", Hosting = "100 Domain Hosting", Cart = "SSL Shopping Cart", Support = "24/7 Live Support" },
                new Pricing { Id = 3, Title = "Professional <small>Monthly plan</small>", Price = "<sup class='currency'>$</sup><strong>149</strong><sub>.99</sub>", Bandwith = "100GB Monthly Bandwidth", AdWords = "$100 Google AdWords", Hosting = "100 Domain Hosting", Cart = "SSL Shopping Cart", Support = "24/7 Live Support" },
                new Pricing { Id = 4, Title = "Premium <small>Monthly plan</small>", Price = "<sup class='currency'>$</sup><strong>399</strong><sub>.99</sub>", Bandwith = "100GB Monthly Bandwidth", AdWords = "$100 Google AdWords", Hosting = "$100 Google AdWords", Cart = "SSL Shopping Cart", Support = "24/7 Live Support" }
                );
            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial { Id = 1, Image = "testimonial1.jpg", SubTitle = "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", Title = "Sarah Arevik<span>Chief Executive</span>" },
                new Testimonial { Id = 2, Image = "testimonial2.jpg", SubTitle = "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", Title = "Narek Bedros<span>Sr. Manager</span>" },
                new Testimonial { Id = 3, Image = "testimonial3.jpg", SubTitle = "Lorem Ipsum as their default model text, and a search for ‘lorem ipsum’ will uncover many web sites stil in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose.Lorem Ipsum is that it as opposed to using.", Title = "Taline Lucine<span>Sales Manager</span>" }
                );
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Image = "client1.png" },
                new Client { Id = 2, Image = "client2.png" },
                new Client { Id = 3, Image = "client3.png" },
                new Client { Id = 4, Image = "client4.png" },
                new Client { Id = 5, Image = "client5.png" },
                new Client { Id = 6, Image = "client6.png" },
                new Client { Id = 7, Image = "client7.png" },
                new Client { Id = 8, Image = "client8.png" }
                );
        }
    }
}
