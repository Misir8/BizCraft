using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
    }
}
