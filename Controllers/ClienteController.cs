using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using migration_relacao_atual.Data;
using migration_relacao_atual.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace migration_relacao_atual.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.Include(c => c.Cnh).ToListAsync());
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewBag.CNHs = _context.CarteirasMotorista.ToList();
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,Nome,CarteiraMotoristaId")] Cliente cliente)
        {
            try
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");

            }
            return View(cliente);
        }
    }
}
