using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class Counter
    {
        public int Id { get; set; }
        [Required, MinLength(0)]
        public int Count { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
    }
}
