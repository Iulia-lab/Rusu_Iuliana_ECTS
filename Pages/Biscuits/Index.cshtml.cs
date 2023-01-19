using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rusu_Iuliana_ECTS.Data;
using Rusu_Iuliana_ECTS.Models;

namespace Rusu_Iuliana_ECTS.Pages.Biscuits
{
    public class IndexModel : PageModel
    {
        private readonly Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext _context;

        public IndexModel(Rusu_Iuliana_ECTS.Data.Rusu_Iuliana_ECTSContext context)
        {
            _context = context;
        }

        public IList<Biscuit> Biscuit { get;set; } = default!;

        public async Task OnGetAsync() => Biscuit = await _context.Biscuit
                .Include(b => b.Publisher)
                .ToListAsync();

    }
}
