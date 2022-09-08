using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Tur
    {
        [Key]
        public int turId { get; set; }

        [StringLength(20)]
        public string turIsim { get; set; }
        public bool durum { get; set; }
        public ICollection<Film> films { get; set; } //film tablosuyla ilişkilendirdik!
    }
}
