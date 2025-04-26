using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DangVanTai.Models;

public class NhanVienController : Controller
{
    private readonly AppDbContext _context;

    public NhanVienController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var NhanVien = await _context.NhanVien
            .Include(e => e.PhongBan)
            .ToListAsync();
        return View(NhanVien);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();
        var NhanVien = await _context.NhanVien
            .Include(e => e.PhongBan)
            .FirstOrDefaultAsync(m => m.MaNhanVien == id);
        if (NhanVien == null) return NotFound();
        return View(NhanVien);
    }
}