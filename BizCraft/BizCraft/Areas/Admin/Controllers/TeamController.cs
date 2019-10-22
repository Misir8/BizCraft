using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BizCraft.Models;
using BizCraft.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using BizCraft.Extensions;
using Microsoft.AspNetCore.Hosting;

namespace BizCraft.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class TeamController : Controller
    {
        private IHostingEnvironment _env { get; }
        private DataContext _context { get; }
        public TeamController(DataContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teams);
        }
        //Edit
        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Team team = await _context.Teams.FindAsync(id);
            if (team == null) return NotFound();
            return View(team);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }

            var TeamDb = await _context.Teams.FindAsync(team.Id);
            if (team.Photo != null)
            {
                try
                {
                    var newPhoto = await team.Photo.SaveFileAsync(_env.WebRootPath, "images/team");
                    IFormFileExtension.Delete(_env.WebRootPath, "images/team", TeamDb.Image);
                    TeamDb.Image = newPhoto;
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unexpected error happened while saving image. Please, try again.");
                    return View(team);
                }
            }

            TeamDb.Title = team.Title;
            TeamDb.SubTitle = team.SubTitle;
            TeamDb.Facebook = team.Facebook;
            TeamDb.Twitter = team.Twitter;
            TeamDb.Google = team.Google;
            TeamDb.Linkedin = team.Linkedin;
            TeamDb.Dribble = team.Dribble;
            await _context.SaveChangesAsync();
            TempData["succes_message"] = "Team was updated successfuly";
            return RedirectToAction(nameof(Index));
        }
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            if (!ModelState.IsValid) return View(team);
            //photo operations
            if (!team.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Image type is not exists");
                return View(team);
                
            }
            if (!team.Photo.IsLarger(1))
            {
                ModelState.AddModelError("Photo", "Image size can be larger 1 mg");
                return View(team);
            }

            team.Image = await team.Photo.SaveFileAsync(_env.WebRootPath, "images/team");

            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            
        }
        //Delete
        [HttpGet]
        public async Task<IActionResult> Remove(int? id)
        {
            if (_context.Teams.Count() <= 2)
            {
                return RedirectToAction(nameof(Index));
            }
            if (id != null)
            {
                Team team = await _context.Teams.FindAsync(id);
                return View(team);
            }
            return NotFound();
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        [ActionName("Remove")]
        public async Task <IActionResult> RemovePost(int? id)
        {
            if (id != null)
            {
                Team team = await _context.Teams.FirstOrDefaultAsync(t => t.Id == id);
                if (team != null)
                {
                    IFormFileExtension.Delete(_env.WebRootPath, "images/team", team.Image);
                    _context.Teams.Remove(team);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return NotFound();
        }
    }
}