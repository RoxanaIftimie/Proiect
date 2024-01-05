using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Models;

namespace Proiect_Iftimie_Roxana_Valentina_CIGgr3.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context _context;

        public IndexModel(Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Car != null)
            {
                Car = await _context.Car.ToListAsync();
            }
        }
    }
}
