using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class MyModelsController : Controller
    {
        private readonly MeetingContext _context;

        public MyModelsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: MyModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.MyModel.ToListAsync());
        }

        // GET: MyModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myModel = await _context.MyModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myModel == null)
            {
                return NotFound();
            }

            return View(myModel);
        }

        // GET: MyModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,name,artist,book,bookFilter,collectionFilter,url,alturl,mp3,playerlink,pdf,video1,video2,showAsterisk,hasDownload,midi,songid,songNumber,detailColumn")] MyModel myModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myModel);
        }

        // GET: MyModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myModel = await _context.MyModel.FindAsync(id);
            if (myModel == null)
            {
                return NotFound();
            }
            return View(myModel);
        }

        // POST: MyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,name,artist,book,bookFilter,collectionFilter,url,alturl,mp3,playerlink,pdf,video1,video2,showAsterisk,hasDownload,midi,songid,songNumber,detailColumn")] MyModel myModel)
        {
            if (id != myModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyModelExists(myModel.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(myModel);
        }

        // GET: MyModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myModel = await _context.MyModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (myModel == null)
            {
                return NotFound();
            }

            return View(myModel);
        }

        // POST: MyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myModel = await _context.MyModel.FindAsync(id);
            _context.MyModel.Remove(myModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyModelExists(int id)
        {
            return _context.MyModel.Any(e => e.ID == id);
        }
    }
}
