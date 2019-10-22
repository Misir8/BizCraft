using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizCraft.DAL;
using BizCraft.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BizCraft.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PricingController : Controller
    {
        private DataContext _context  { get;}
        public PricingController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Pricings);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Pricing pricing = await _context.Pricings.FindAsync(id);
                if (pricing != null)
                {
                    return View(pricing);
                }
             }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Pricing pricing)
        {
            _context.Pricings.Update(pricing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Pricing pricing)
        {
            if (!ModelState.IsValid) return View(pricing);
            await _context.Pricings.AddAsync(pricing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Delete
        public IActionResult Remove()
        {
            return View();
        }
        //[HttpGet]
        //public async Task<IActionResult> ConfirmRemove(int? id)
        //{
        //    if (id != null)
        //    {
        //        Pricing pricing = await _context.Pricings.FirstOrDefaultAsync(p => p.Id == id);
        //        return View(pricing);
        //    }
        //    return NotFound();
        //}
        [HttpPost]
        public async Task<IActionResult> Remove(int? id)
        {
            if (id != null)
            {
                Pricing pricing = await _context.Pricings.FirstOrDefaultAsync(p => p.Id == id);
                if (pricing != null)
                {
                    _context.Pricings.Remove(pricing);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return NotFound();
        }
    }
}