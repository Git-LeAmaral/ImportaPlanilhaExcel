using ImportaPlanilhaExcel.Data;
using ImportaPlanilhaExcel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ImportaPlanilhaExcel.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }

    }
}
