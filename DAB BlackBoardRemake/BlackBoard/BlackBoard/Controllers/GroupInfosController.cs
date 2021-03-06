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
    public class GroupInfosController : Controller
    {
        private readonly MyDBContext _context;

        public GroupInfosController(MyDBContext context)
        {
            _context = context;
        }

        // GET: GroupInfos
        public async Task<IActionResult> Index()
        {
            var myDBContext = _context.GroupsInfo.Include(g => g.Group).Include(g => g.Student);
            return View(await myDBContext.ToListAsync());
        }

        // GET: GroupInfos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupInfo = await _context.GroupsInfo
                .Include(g => g.Group)
                .Include(g => g.Student)
                .FirstOrDefaultAsync(m => m.GroupInfoId == id);
            if (groupInfo == null)
            {
                return NotFound();
            }

            return View(groupInfo);
        }

        // GET: GroupInfos/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "GroupId");
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName");
            return View();
        }

        // POST: GroupInfos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupInfoId,GroupSize,StudentAuId,GroupId")] GroupInfo groupInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "GroupId", groupInfo.GroupId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", groupInfo.StudentAuId);
            return View(groupInfo);
        }

        // GET: GroupInfos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupInfo = await _context.GroupsInfo.FindAsync(id);
            if (groupInfo == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "GroupId", groupInfo.GroupId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", groupInfo.StudentAuId);
            return View(groupInfo);
        }

        // POST: GroupInfos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupInfoId,GroupSize,StudentAuId,GroupId")] GroupInfo groupInfo)
        {
            if (id != groupInfo.GroupInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupInfoExists(groupInfo.GroupInfoId))
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
            ViewData["GroupId"] = new SelectList(_context.Set<Group>(), "GroupId", "GroupId", groupInfo.GroupId);
            ViewData["StudentAuId"] = new SelectList(_context.Students, "StudentAuId", "FirstName", groupInfo.StudentAuId);
            return View(groupInfo);
        }

        // GET: GroupInfos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupInfo = await _context.GroupsInfo
                .Include(g => g.Group)
                .Include(g => g.Student)
                .FirstOrDefaultAsync(m => m.GroupInfoId == id);
            if (groupInfo == null)
            {
                return NotFound();
            }

            return View(groupInfo);
        }

        // POST: GroupInfos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupInfo = await _context.GroupsInfo.FindAsync(id);
            _context.GroupsInfo.Remove(groupInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupInfoExists(int id)
        {
            return _context.GroupsInfo.Any(e => e.GroupInfoId == id);
        }
    }
}
