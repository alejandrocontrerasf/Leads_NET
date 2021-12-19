using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GT_Leads_NET.Models;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace GT_Leads_NET
{
    public class LeadController : Controller
    {

        private readonly LeadContext _context;

        public LeadController(LeadContext context)
        {
            _context = context;
        }

       

        // GET: Lead
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leads.ToListAsync());
        }

        // GET: Lead/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lead = await _context.Leads
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lead == null)
            {
                return NotFound();
            }

            return View(lead);
        }


        // GET: Lead/Create
        public IActionResult Create()
        {
            ViewBag.Eventos = _context.Eventos.ToList();
            return View();
        }

        // POST: Lead/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Telefono,Correo,Ciudad,Evento")] Lead lead)
        {

            if (ModelState.IsValid)
            {
                _context.Add(lead);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           
            return View();
        }



        // GET: Lead/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Eventos = _context.Eventos.ToList();
            var lead = await _context.Leads.FindAsync(id);
            if (lead == null)
            {
                return NotFound();
            }
            return View(lead);
        }

        // POST: Lead/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Telefono,Correo,Ciudad,Evento")] Lead lead)
        {
            if (id != lead.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lead);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeadExists(lead.ID))
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
            return View(lead);
        }

        // GET: Lead/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lead = await _context.Leads
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lead == null)
            {
                return NotFound();
            }

            return View(lead);
        }

        // POST: Lead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lead = await _context.Leads.FindAsync(id);
            _context.Leads.Remove(lead);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeadExists(int id)
        {
            return _context.Leads.Any(e => e.ID == id);
        }
    }
}
