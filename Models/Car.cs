using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Iftimie_Roxana_Valentina_CIGgr3.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Display(Name = "Brand")]
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    } 
} 
