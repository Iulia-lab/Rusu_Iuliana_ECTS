using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rusu_Iuliana_ECTS.Data;
using Rusu_Iuliana_ECTS.Models;

namespace Rusu_Iuliana_ECTS.Pages.Cantitati
{
    public class EditModel : PageModel
    {
        private readonly Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext _context;

        public EditModel(Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cantitate Cantitate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cantitate == null)
            {
                return NotFound();
            }

            var cantitate =  await _context.Cantitate.FirstOrDefaultAsync(m => m.ID == id);
            if (cantitate == null)
            {
                return NotFound();
            }
            Cantitate = cantitate;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cantitate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CantitateExists(Cantitate.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CantitateExists(int id)
        {
          return _context.Cantitate.Any(e => e.ID == id);
        }
    }
}
