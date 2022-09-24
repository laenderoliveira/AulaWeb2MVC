using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AulaWeb2MVC.Data;
using AulaWeb2MVC.Models;

namespace AulaWeb2MVC.Controllers
{
    public class FaculdadeController : Controller
    {
        private readonly AulaWeb2MVCContexto _context;

        public FaculdadeController(AulaWeb2MVCContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return View(await _context.FaculdadeModel.ToListAsync());
        }

        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.FaculdadeModel == null)
            {
                return NotFound();
            }

            var faculdadeModel = await _context.FaculdadeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faculdadeModel == null)
            {
                return NotFound();
            }

            return View(faculdadeModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeFantasia,NomeCompleto")] FaculdadeModel faculdadeModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faculdadeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faculdadeModel);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.FaculdadeModel == null)
            {
                return NotFound();
            }

            var faculdadeModel = await _context.FaculdadeModel.FindAsync(id);
            if (faculdadeModel == null)
            {
                return NotFound();
            }
            return View(faculdadeModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NomeFantasia,NomeCompleto")] FaculdadeModel faculdadeModel)
        {
            if (id != faculdadeModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faculdadeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FaculdadeModelExists(faculdadeModel.Id))
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
            return View(faculdadeModel);
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.FaculdadeModel == null)
            {
                return NotFound();
            }

            var faculdadeModel = await _context.FaculdadeModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (faculdadeModel == null)
            {
                return NotFound();
            }

            return View(faculdadeModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.FaculdadeModel == null)
            {
                return Problem("Entity set 'AulaWeb2MVCContexto.FaculdadeModel'  is null.");
            }
            var faculdadeModel = await _context.FaculdadeModel.FindAsync(id);
            if (faculdadeModel != null)
            {
                _context.FaculdadeModel.Remove(faculdadeModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FaculdadeModelExists(long id)
        {
          return _context.FaculdadeModel.Any(e => e.Id == id);
        }
    }
}
