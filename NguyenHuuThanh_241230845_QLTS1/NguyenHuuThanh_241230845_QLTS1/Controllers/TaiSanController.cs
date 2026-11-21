using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenHuuThanh_241230845_QLTS1.Data;
using NguyenHuuThanh_241230845_QLTS1.Models;

namespace NguyenHuuThanh_241230845_QLTS1.Controllers
{
    public class TaiSanController : Controller
    {
        private readonly AppDbContext _context;

        public TaiSanController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TaiSan
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.TaiSans.Include(t => t.MaLoaiNavigation);
            return View(await appDbContext.ToListAsync());
        }

        // GET: TaiSan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiSan = await _context.TaiSans
                .Include(t => t.MaLoaiNavigation)
                .FirstOrDefaultAsync(m => m.MaTs == id);
            if (taiSan == null)
            {
                return NotFound();
            }

            return View(taiSan);
        }

        // GET: TaiSan/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.LoaiTaiSans, "MaLoai", "MaLoai");
            return View();
        }

        // POST: TaiSan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("MaTs,MaLoai,TenTs,NguyenGia,Anh")] TaiSan taiSan)
        {
            
            if (ModelState.IsValid)
            {

                _context.Add(taiSan);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiTaiSans, "MaLoai", "MaLoai", taiSan.MaLoai);
            return View(taiSan);
        }

        // GET: TaiSan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiSan = await _context.TaiSans.FindAsync(id);
            if (taiSan == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiTaiSans, "MaLoai", "MaLoai", taiSan.MaLoai);
            return View(taiSan);
        }

        // POST: TaiSan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTs,MaLoai,TenTs,NguyenGia,Anh")] TaiSan taiSan)
        {
            if (id != taiSan.MaTs)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiSan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiSanExists(taiSan.MaTs))
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
            ViewData["MaLoai"] = new SelectList(_context.LoaiTaiSans, "MaLoai", "MaLoai", taiSan.MaLoai);
            return View(taiSan);
        }

        // GET: TaiSan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiSan = await _context.TaiSans
                .Include(t => t.MaLoaiNavigation)
                .FirstOrDefaultAsync(m => m.MaTs == id);
            if (taiSan == null)
            {
                return NotFound();
            }

            return View(taiSan);
        }

        // POST: TaiSan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taiSan = await _context.TaiSans.FindAsync(id);
            if (taiSan != null)
            {
                _context.TaiSans.Remove(taiSan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiSanExists(int id)
        {
            return _context.TaiSans.Any(e => e.MaTs == id);
        }
    }
}
