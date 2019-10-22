using BizCraft.Models;
using BizCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bizcraft.ViewModels
{
    public class HomeIndexVM
    {

        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<ServiceProvide> ServiceProvides { get; set; }
        public IEnumerable<AwesomeWork> AwesomeWorks { get; set; }
        public IEnumerable<Counter> Counters { get; set; }
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<AboutInfoImage> AboutInfoImages { get; set; }
        public IEnumerable<AboutCompany> AboutCompanies { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Pricing> Pricings { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
