using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rusu_Iuliana_ECTS.Data;
using Rusu_Iuliana_ECTS.Models;

namespace Rusu_Iuliana_ECTS.Pages.Cantitati
{
    public class DetailsModel : PageModel
    {
        private readonly Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext _context;

        public DetailsModel(Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext context)
        {
            _context = context;
        }

      public Cantitate Cantitate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cantitate == null)
            {
                return NotFound();
            }

            var cantitate = await _context.Cantitate.FirstOrDefaultAsync(m => m.ID == id);
            if (cantitate == null)
            {
                return NotFound();
            }
            else 
            {
                Cantitate = cantitate;
            }
            return Page();
        }
    }
}
