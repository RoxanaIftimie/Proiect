using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Iftimie_Roxana_Valentina_CIGgr3.Models;

namespace Proiect_Iftimie_Roxana_Valentina_CIGgr3.Data
{
    public class Proiect_Iftimie_Roxana_Valentina_CIGgr3Context : DbContext
    {
        public Proiect_Iftimie_Roxana_Valentina_CIGgr3Context (DbContextOptions<Proiect_Iftimie_Roxana_Valentina_CIGgr3Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Iftimie_Roxana_Valentina_CIGgr3.Models.Car> Car { get; set; } = default!;
    }
}
