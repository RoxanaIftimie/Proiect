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
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context _context;

        public DetailsModel(Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context context)
        {
            _context = context;
        }

      public Car Car { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FirstOrDefaultAsync(m => m.ID == id);
            if (car == null)
            {
                return NotFound();
            }
            else 
            {
                Car = car;
            }
            return Page();
        }
    }
}
