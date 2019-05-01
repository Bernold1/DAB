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
    public class CourseManagementsController : Controller
    {
        private readonly MyDBContext _context;

        public CourseManagementsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: CourseManagements
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.CourseManagement.Include(c => c.Course).Include(c => c.Teacher);
            return View(await myDBContext.ToListAsync());
        }

        // GET: CourseManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseManagement = await _context.CourseManagement
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseManagementId == id);
            if (courseManagement == null)
            {
                return NotFound();
            }

            return View(courseManagement);
        }

        // GET: CourseManagements/Create
        public IActionResult Create()
        {
            ViewData["CouseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName");
            return View();
        }

        // POST: CourseManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseManagementId,CouseId,TeacherAuId")] CourseManagement courseManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CouseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseManagement.CouseId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", courseManagement.TeacherAuId);
            return View(courseManagement);
        }

        // GET: CourseManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseManagement = await _context.CourseManagement.FindAsync(id);
            if (courseManagement == null)
            {
                return NotFound();
            }
            ViewData["CouseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseManagement.CouseId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", courseManagement.TeacherAuId);
            return View(courseManagement);
        }

        // POST: CourseManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseManagementId,CouseId,TeacherAuId")] CourseManagement courseManagement)
        {
            if (id != courseManagement.CourseManagementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseManagementExists(courseManagement.CourseManagementId))
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
            ViewData["CouseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseManagement.CouseId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", courseManagement.TeacherAuId);
            return View(courseManagement);
        }

        // GET: CourseManagements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseManagement = await _context.CourseManagement
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseManagementId == id);
            if (courseManagement == null)
            {
                return NotFound();
            }

            return View(courseManagement);
        }

        // POST: CourseManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseManagement = await _context.CourseManagement.FindAsync(id);
            _context.CourseManagement.Remove(courseManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseManagementExists(int id)
        {
            return _context.CourseManagement.Any(e => e.CourseManagementId == id);
        }
    }
}
