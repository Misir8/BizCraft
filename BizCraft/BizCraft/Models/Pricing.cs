using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Price { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Bandwith { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string AdWords { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Hosting { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Cart { get; set; }
        [Required(ErrorMessage = "Mutleq doldurulmalidir"), StringLength(100)]
        public string Support { get; set; }
    }
}
