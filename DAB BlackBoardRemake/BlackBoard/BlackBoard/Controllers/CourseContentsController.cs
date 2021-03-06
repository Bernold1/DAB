﻿using System;
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
    public class CourseContentsController : Controller
    {
        private readonly MyDBContext _context;

        public CourseContentsController(MyDBContext context)
        {
            _context = context;
        }

        // GET: CourseContents
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.CourseContents.Include(c => c.Course);
            return View(await myDBContext.ToListAsync());
        }

        // GET: CourseContents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseContent = await _context.CourseContents
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.CourseContentId == id);
            if (courseContent == null)
            {
                return NotFound();
            }

            return View(courseContent);
        }

        // GET: CourseContents/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            return View();
        }

        // POST: CourseContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseContentId,ContentName,CourseId")] CourseContent courseContent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseContent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // GET: CourseContents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseContent = await _context.CourseContents.FindAsync(id);
            if (courseContent == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // POST: CourseContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseContentId,ContentName,CourseId")] CourseContent courseContent)
        {
            if (id != courseContent.CourseContentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseContentExists(courseContent.CourseContentId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // GET: CourseContents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseContent = await _context.CourseContents
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.CourseContentId == id);
            if (courseContent == null)
            {
                return NotFound();
            }

            return View(courseContent);
        }

        // POST: CourseContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseContent = await _context.CourseContents.FindAsync(id);
            _context.CourseContents.Remove(courseContent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseContentExists(int id)
        {
            return _context.CourseContents.Any(e => e.CourseContentId == id);
        }
    }
}
