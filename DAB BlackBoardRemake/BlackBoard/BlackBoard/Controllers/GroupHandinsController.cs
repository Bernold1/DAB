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
    public class GroupHandinsController : Controller
    {
        private readonly MyDBContext _context;

        public GroupHandinsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: GroupHandins
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.GroupHandins.Include(g => g.Assignment).Include(g => g.Group).Include(g => g.Teacher);
            return View(await myDBContext.ToListAsync());
        }

        // GET: GroupHandins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHandin = await _context.GroupHandins
                .Include(g => g.Assignment)
                .Include(g => g.Group)
                .ThenInclude(g => g.GroupInfos)
                .Include(g => g.Teacher)
                .FirstOrDefaultAsync(m => m.GroupHandinId == id);
            if (groupHandin == null)
            {
                return NotFound();
            }

            return View(groupHandin);
        }

        // GET: GroupHandins/Create
        public IActionResult Create()
        {
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentName");
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId");
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName");
            return View();
        }

        // POST: GroupHandins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupHandinId,AssignmentId,GroupId,TeacherAuId")] GroupHandin groupHandin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupHandin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentName", groupHandin.AssignmentId);
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupHandin.GroupId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", groupHandin.TeacherAuId);
            return View(groupHandin);
        }

        // GET: GroupHandins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHandin = await _context.GroupHandins.FindAsync(id);
            if (groupHandin == null)
            {
                return NotFound();
            }
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentName", groupHandin.AssignmentId);
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupHandin.GroupId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", groupHandin.TeacherAuId);
            //ViewData["Grade"] = new SelectList(_context.GroupHandins, "Grade", "Grade", groupHandin.GroupHandinId);
            return View(groupHandin);
        }

        // POST: GroupHandins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupHandinId,AssignmentId,GroupId,TeacherAuId")] GroupHandin groupHandin)
        {
            if (id != groupHandin.GroupHandinId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupHandin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupHandinExists(groupHandin.GroupHandinId))
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
            ViewData["AssignmentId"] = new SelectList(_context.Assignment, "AssignmentId", "AssignmentName", groupHandin.AssignmentId);
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupHandin.GroupId);
            ViewData["TeacherAuId"] = new SelectList(_context.Teachers, "TeacherAuId", "FirstName", groupHandin.TeacherAuId);
            return View(groupHandin);
        }

        // GET: GroupHandins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupHandin = await _context.GroupHandins
                .Include(g => g.Assignment)
                .Include(g => g.Group)
                .Include(g => g.Teacher)
                .FirstOrDefaultAsync(m => m.GroupHandinId == id);
            if (groupHandin == null)
            {
                return NotFound();
            }

            return View(groupHandin);
        }

        // POST: GroupHandins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupHandin = await _context.GroupHandins.FindAsync(id);
            _context.GroupHandins.Remove(groupHandin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupHandinExists(int id)
        {
            return _context.GroupHandins.Any(e => e.GroupHandinId == id);
        }
    }
}
