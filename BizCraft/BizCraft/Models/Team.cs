using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace BizCraft.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [MinLength(5, ErrorMessage = "En azi {1} simvoldan ibaret olmalidir")]
        [Display(Name = "Ad ve Soyad")]
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Title { get; set; }
        [MinLength(5, ErrorMessage = "En azi {1} simvoldan ibaret olmalidir")]
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(200)]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Facebook { get; set; }
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Twitter { get; set; }
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Google { get; set; }
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Linkedin { get; set; }
        [Required(ErrorMessage = "Mutleq Doldurulmalidir"), StringLength(100)]
        public string Dribble { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
