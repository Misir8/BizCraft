using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string SubTitle { get; set; }
        public string ButtonOne { get; set; }
        [Required, StringLength(50)]
        public string ButtonTwo { get; set; }
    }
}
