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
    public class SpeakingAssignmentsController : Controller
    {
        private readonly MeetingContext _context;

        public SpeakingAssignmentsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: SpeakingAssignments
        public async Task<IActionResult> Index(
             string sortOrder,
             string currentFilter,
             string searchString,
             int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["TopicSortParm"] =
                String.IsNullOrEmpty(sortOrder) ? "Topic_desc" : "";
            ViewData["DateSortParm"] =
                sortOrder == "MeetingDate" ? "MeetingDate_desc" : "MeetingDate";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var meetingContext = _context.SpeakingAssignments.Include(s => s.Meeting).Include(s => s.Speaker);


            if (!String.IsNullOrEmpty(searchString))
            {
                meetingContext = _context.SpeakingAssignments.Where(s => s.Topic.Contains(searchString)).Include(s => s.Meeting).Include(s => s.Speaker);
            }

            if (string.IsNullOrEmpty(sortOrder))
            {
                sortOrder = "Topic";
            }

            bool descending = false;

            if (sortOrder.EndsWith("_desc"))
            {
                sortOrder = sortOrder.Substring(0, sortOrder.Length - 5);
                descending = true;
            }


            if (descending)
            {
                meetingContext = _context.SpeakingAssignments.OrderByDescending(e => e.Topic).Include(s => s.Meeting).Include(s => s.Speaker);
            }
            else
            {
                meetingContext = _context.SpeakingAssignments.OrderBy(e => e.Topic).Include(s => s.Meeting).Include(s => s.Speaker);
            }


            return View(await meetingContext.AsNoTracking().ToListAsync());

        }

        // GET: SpeakingAssignments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakingAssignment = await _context.SpeakingAssignments
                .Include(s => s.Meeting)
                .Include(s => s.Speaker)
                .FirstOrDefaultAsync(m => m.SpeakingAssignmentID == id);
            if (speakingAssignment == null)
            {
                return NotFound();
            }

            return View(speakingAssignment);
        }

        // GET: SpeakingAssignments/Create
        public IActionResult Create()
        {
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID");
            ViewData["SpeakerID"] = new SelectList(_context.Speakers, "ID", "ID");
            return View();
        }

        // POST: SpeakingAssignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpeakingAssignmentID,MeetingID,SpeakerID,Topic")] SpeakingAssignment speakingAssignment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speakingAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID", speakingAssignment.MeetingID);
            ViewData["SpeakerID"] = new SelectList(_context.Speakers, "ID", "ID", speakingAssignment.SpeakerID);
            return View(speakingAssignment);
        }

        // GET: SpeakingAssignments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakingAssignment = await _context.SpeakingAssignments.FindAsync(id);
            if (speakingAssignment == null)
            {
                return NotFound();
            }
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID", speakingAssignment.MeetingID);
            ViewData["SpeakerID"] = new SelectList(_context.Speakers, "ID", "ID", speakingAssignment.SpeakerID);
            return View(speakingAssignment);
        }

        // POST: SpeakingAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpeakingAssignmentID,MeetingID,SpeakerID,Topic")] SpeakingAssignment speakingAssignment)
        {
            if (id != speakingAssignment.SpeakingAssignmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speakingAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpeakingAssignmentExists(speakingAssignment.SpeakingAssignmentID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "Meetings");


            }
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID", speakingAssignment.MeetingID);
            ViewData["SpeakerID"] = new SelectList(_context.Speakers, "ID", "ID", speakingAssignment.SpeakerID);
            return View(speakingAssignment);
        }

        // GET: SpeakingAssignments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var speakingAssignment = await _context.SpeakingAssignments
                .Include(s => s.Meeting)
                .Include(s => s.Speaker)
                .FirstOrDefaultAsync(m => m.SpeakingAssignmentID == id);
            if (speakingAssignment == null)
            {
                return NotFound();
            }

            return View(speakingAssignment);
        }

        // POST: SpeakingAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var speakingAssignment = await _context.SpeakingAssignments.FindAsync(id);
            _context.SpeakingAssignments.Remove(speakingAssignment);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return RedirectToAction("Index", "Meetings");

        }

        private bool SpeakingAssignmentExists(int id)
        {
            return _context.SpeakingAssignments.Any(e => e.SpeakingAssignmentID == id);
        }
    }
}
