
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NhtLesson11Lab04.Models;
using NhtLesson11Lab04.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

public class LearnerController : Controller
{
    private readonly SchoolDBContext _context;

    public LearnerController(SchoolDBContext context)
    {
        _context = context;
    }

    // GET: LEARNERS
    public async Task<IActionResult> Index()    
    {
        var learners = await _context.Learners
            .Include(learner => learner.Major)
            .Include(learner => learner.Enrollments)
                .ThenInclude(enrollment => enrollment.Course)
            .ToListAsync();

        return View(learners);
    }

    // GET: LEARNERS/Details/5
    public async Task<IActionResult> Details(int? learnerid)
    {
        if (learnerid == null)
        {
            return NotFound();
        }

        var learner = await _context.Learners
            .FirstOrDefaultAsync(m => m.LearnerID == learnerid);
        if (learner == null)
        {
            return NotFound();
        }

        return View(learner);
    }

    // GET: LEARNERS/Create
    public IActionResult Create()
    {
        ViewBag.MajorID = new SelectList(_context.Majors, "MajorID", "MajorName");
        return View();
    }

    // POST: LEARNERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("LearnerID,LastName,FirstMidName,EnrollmentDate,MajorID,Major,Enrollments")] Learner learner)
    {
        if (ModelState.IsValid)
        {
            _context.Add(learner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.MajorID = new SelectList(_context.Majors, "MajorID", "MajorName");

        return View(learner);
    }

    // GET: LEARNERS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var learner = await _context.Learners.FindAsync(id);
        if (learner == null)
        {
            return NotFound();
        }
        return View(learner);
    }

    // POST: LEARNERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("LearnerID,LastName,FirstMidName,EnrollmentDate,MajorID,Major,Enrollments")] Learner learner)
    {
        if (id != learner.LearnerID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(learner);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LearnerExists(learner.LearnerID))
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
        return View(learner);
    }

    // GET: LEARNERS/Delete/5
    public async Task<IActionResult> Delete(int? learnerid)
    {
        if (learnerid == null)
        {
            return NotFound();
        }

        var learner = await _context.Learners
            .FirstOrDefaultAsync(m => m.LearnerID == learnerid);
        if (learner == null)
        {
            return NotFound();
        }

        return View(learner);
    }

    // POST: LEARNERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? learnerid)
    {
        var learner = await _context.Learners.FindAsync(learnerid);
        if (learner != null)
        {
            _context.Learners.Remove(learner);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LearnerExists(int? learnerid)
    {
        return _context.Learners.Any(e => e.LearnerID == learnerid);
    }
}
