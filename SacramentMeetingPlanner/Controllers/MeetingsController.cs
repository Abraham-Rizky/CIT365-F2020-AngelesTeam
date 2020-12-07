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
    public class MeetingsController : Controller
    {
        private readonly MeetingContext _context;

        public MeetingsController(MeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Meetings.ToListAsync());
            var meetingContext = _context.Meetings.Include(s => s.SpeakingAssignments).Include(s => s.Speakers);
            return View(await meetingContext.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(s => s.SpeakingAssignments)
                    .ThenInclude(e => e.Speaker)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Conductor,OpeningHymn,Invocation,SacramentHymn,ClosingHymn,Benediction,Notes")] Meeting meeting, Speaker speaker)
        {
            if (ModelState.IsValid)
            {
                //string name = Request.Form["name"]
                _context.Add(meeting);

                //Speaker speaker = new Speaker();

                speaker.Name = Request.Form["Name"];
                _context.AddRange(speaker);

                SpeakingAssignment topic = new SpeakingAssignment();
                topic.Topic = Request.Form["Topic"];
                topic.MeetingID = meeting.ID;
                topic.SpeakerID = speaker.ID;
                _context.AddRange(topic);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var meeting = await _context.Meetings.FindAsync(id);
            var meeting = await _context.Meetings
                .Include(s => s.SpeakingAssignments)
                    .ThenInclude(e => e.Speaker)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Conductor,OpeningHymn,Invocation,SacramentHymn,ClosingHymn,Benediction,Notes")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    
                    Speaker speaker = new Speaker();
                    speaker.Name = Request.Form["Name"];
                    _context.Add(speaker);

                    SpeakingAssignment topic = new SpeakingAssignment();
                    topic.Topic = Request.Form["Topic"];
                    topic.MeetingID = meeting.ID;
                    topic.SpeakerID = speaker.ID;
                    _context.Add(topic);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
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
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*            var meeting = await _context.Meetings
                            .FirstOrDefaultAsync(m => m.ID == id);*/
            var meeting = await _context.Meetings
                .Include(s => s.SpeakingAssignments)
                    .ThenInclude(e => e.Speaker)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meetings.Any(e => e.ID == id);
        }
    }
}
