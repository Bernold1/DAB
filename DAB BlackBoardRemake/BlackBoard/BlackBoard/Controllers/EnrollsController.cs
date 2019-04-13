using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlackBoard.Data;
using BlackBoard.Models;

namespace BlackBoard.Controllers
{
    public class EnrollsController : Controller
    {
        private readonly MyDBContext _context;

        public EnrollsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: Enrolls
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.Enrolls.Include(e => e.Course).Include(e => e.Student);
            return View(await myDBContext.ToListAsync());
        }

        // GET: Enrolls/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enrolls
                .Include(e => e.Course)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (enroll == null)
            {
                return NotFound();
            }

            return View(enroll);
        }

        // GET: Enrolls/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName");
            return View();
        }

        // POST: Enrolls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,StudentAuId")] Enroll enroll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enroll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", enroll.CourseId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", enroll.StudentAuId);
            return View(enroll);
        }

        // GET: Enrolls/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enrolls.FindAsync(id);
            if (enroll == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", enroll.CourseId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", enroll.StudentAuId);
            return View(enroll);
        }

        // POST: Enrolls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CourseId,StudentAuId")] Enroll enroll)
        {
            if (id != enroll.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enroll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollExists(enroll.CourseId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", enroll.CourseId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", enroll.StudentAuId);
            return View(enroll);
        }

        // GET: Enrolls/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enrolls
                .Include(e => e.Course)
                .Include(e => e.Student)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (enroll == null)
            {
                return NotFound();
            }

            return View(enroll);
        }

        // POST: Enrolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var enroll = await _context.Enrolls.FindAsync(id);
            _context.Enrolls.Remove(enroll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollExists(string id)
        {
            return _context.Enrolls.Any(e => e.CourseId == id);
        }
    }
}
