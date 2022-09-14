using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Slider
    {
        [Key]
        public int sliderId { get; set; }

        [StringLength(20)]
        public string baslik { get; set; }

        [StringLength(100)]
        public string icerik { get; set; }

        [StringLength(100)]
        public string resimUrl { get; set; }
        
    }
}
