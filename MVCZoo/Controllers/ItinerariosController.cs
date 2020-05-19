﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCZoo.Models;

namespace MVCZoo.Controllers
{
    public class ItinerariosController : Controller
    {
        private readonly Contexto _context;

        public ItinerariosController(Contexto context)
        {
            _context = context;
        }

        // GET: Itinerarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Itinerario.ToListAsync());
        }

        // GET: Itinerarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerario = await _context.Itinerario
                .Include(c => c.Habitats)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itinerario == null)
            {
                return NotFound();
            }

            return View(itinerario);
        }

        // GET: Itinerarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Itinerarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Visitantes,Duracion,Longitud")] Itinerario itinerario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itinerario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itinerario);
        }

        // GET: Itinerarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerario = await _context.Itinerario.FindAsync(id);
            if (itinerario == null)
            {
                return NotFound();
            }
            return View(itinerario);
        }

        // POST: Itinerarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Visitantes,Duracion,Longitud")] Itinerario itinerario)
        {
            if (id != itinerario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itinerario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItinerarioExists(itinerario.Id))
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
            return View(itinerario);
        }

        // GET: Itinerarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itinerario = await _context.Itinerario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itinerario == null)
            {
                return NotFound();
            }

            return View(itinerario);
        }

        // POST: Itinerarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itinerario = await _context.Itinerario.FindAsync(id);
            _context.Itinerario.Remove(itinerario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItinerarioExists(int id)
        {
            return _context.Itinerario.Any(e => e.Id == id);
        }
    }
}
