using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rusu_Iuliana_ECTS.Data;
using Rusu_Iuliana_ECTS.Models;

namespace Rusu_Iuliana_ECTS.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext _context;

        public IndexModel(Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
