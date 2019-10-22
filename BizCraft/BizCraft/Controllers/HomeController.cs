using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizCraft.DAL;
using BizCraft.Models;
using Bizcraft.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bizcraft1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM
            {
                Sliders = _context.Sliders,
                ServiceProvides = _context.ServiceProvides,
                AwesomeWorks = _context.AwesomeWorks,
                Counters = _context.Counters,
                Features = _context.Features,
                AboutInfoImages = _context.AboutInfoImages,
                AboutCompanies = _context.AboutCompanies,
                Teams = _context.Teams,
                Pricings = _context.Pricings, 
                Testimonials = _context.Testimonials,
                Clients = _context.Clients
                
            };
            return View(homeIndexVM);
        }
    }
}