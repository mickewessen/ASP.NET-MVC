using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityPortal.Data;
using UniversityPortal.Entities;

namespace UniversityPortal.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class SchoolCoursesController : Controller
    {
        private readonly UniversityDbContext _context;

        public SchoolCoursesController(UniversityDbContext context)
        {
            _context = context;
        }

        // GET: SchoolCourses
        public async Task<IActionResult> Index()
        {
            return View(await _context.SchoolCourses.ToListAsync());
        }

        // GET: SchoolCourses/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolCourse = await _context.SchoolCourses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schoolCourse == null)
            {
                return NotFound();
            }

            return View(schoolCourse);
        }

        // GET: SchoolCourses/Create
        public IActionResult Create()
        {
            ViewBag.SchoolClass = _context.SchoolClasses;
            return View();
        }

        // POST: SchoolCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseName")] SchoolCourse schoolCourse)
        {
            if (ModelState.IsValid)
            {
                schoolCourse.Id = Guid.NewGuid();
                _context.Add(schoolCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schoolCourse);
        }

        // GET: SchoolCourses/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolCourse = await _context.SchoolCourses.FindAsync(id);
            if (schoolCourse == null)
            {
                return NotFound();
            }
            return View(schoolCourse);
        }

        // POST: SchoolCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CourseName")] SchoolCourse schoolCourse)
        {
            if (id != schoolCourse.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schoolCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchoolCourseExists(schoolCourse.Id))
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
            return View(schoolCourse);
        }

        // GET: SchoolCourses/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolCourse = await _context.SchoolCourses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schoolCourse == null)
            {
                return NotFound();
            }

            return View(schoolCourse);
        }

        // POST: SchoolCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var schoolCourse = await _context.SchoolCourses.FindAsync(id);
            _context.SchoolCourses.Remove(schoolCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolCourseExists(Guid id)
        {
            return _context.SchoolCourses.Any(e => e.Id == id);
        }
    }
}
