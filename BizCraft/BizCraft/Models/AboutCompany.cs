using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizCraft.Models
{
    public class AboutCompany
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(200)]
        public string SubTitle { get; set; }
        [Required, StringLength(200)]
        public string Icon { get; set; }
    }
}
