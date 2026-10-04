using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PUC_DevBE.Models;

namespace PUC_DevBE.Controllers
{
    public class VeiculosController : Controller
    {
        public readonly AppDbContext _context;
        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();

            return View(dados);
        }
    }
}
