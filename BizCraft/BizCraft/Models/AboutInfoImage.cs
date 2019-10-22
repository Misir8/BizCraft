using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class AboutInfoImage
    {
        public int Id { get; set; }
        [Required, StringLength(250)]
        public  string Image { get; set; }
    }
}
