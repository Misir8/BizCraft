using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(1000)]
        public string Title { get; set; }
        [Required, StringLength(5000)]
        public string SubTitle { get; set; }
    }
}
