using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcDentista1.Data;
using MvcDentista1.Models;

namespace MvcDentista1.Controllers
{
    public class DientesController : Controller
    {
        private readonly MvcDentista1Context _context;

        public DientesController(MvcDentista1Context context)
        {
            _context = context;
        }

        // GET: Dientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diente.ToListAsync());
        }

        // GET: Dientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diente = await _context.Diente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diente == null)
            {
                return NotFound();
            }

            return View(diente);
        }

        // GET: Dientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPaciente,Diente1,Diente2,Diente3,Diente4,Diente5,Diente6,Diente7,Diente8,Diente9,Diente10,Diente11,Diente12,Diente13,Diente14,Diente15,Diente16,Diente17,Diente18,Diente19,Diente20,Diente21,Diente22,Diente23,Diente24,Diente25,Diente26,Diente27,Diente28,Diente29,Diente30,Diente31,Diente32")] Diente diente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diente);
        }

        // GET: Dientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diente = await _context.Diente.FindAsync(id);
            if (diente == null)
            {
                return NotFound();
            }
            return View(diente);
        }

        // POST: Dientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPaciente,Diente1,Diente2,Diente3,Diente4,Diente5,Diente6,Diente7,Diente8,Diente9,Diente10,Diente11,Diente12,Diente13,Diente14,Diente15,Diente16,Diente17,Diente18,Diente19,Diente20,Diente21,Diente22,Diente23,Diente24,Diente25,Diente26,Diente27,Diente28,Diente29,Diente30,Diente31,Diente32")] Diente diente)
        {
            if (id != diente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DienteExists(diente.Id))
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
            return View(diente);
        }

        // GET: Dientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diente = await _context.Diente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diente == null)
            {
                return NotFound();
            }

            return View(diente);
        }

        // POST: Dientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diente = await _context.Diente.FindAsync(id);
            _context.Diente.Remove(diente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DienteExists(int id)
        {
            return _context.Diente.Any(e => e.Id == id);
        }
    }
}
