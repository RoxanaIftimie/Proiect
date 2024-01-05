using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Models;

namespace Proiect_Iftimie_Roxana_Valentina_CIGgr3.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context _context;

        public CreateModel(Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data.Proiect_Iftimie_Roxana_Valentina_CIGgr3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Car == null || Car == null)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
