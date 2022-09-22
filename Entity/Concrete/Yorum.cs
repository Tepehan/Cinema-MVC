using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Yorum
    {
        [Key]
        public int yorumId { get; set; }

        [StringLength(250)]
        public string yorum { get; set; }

        [StringLength(20)]
        public string tarih { get; set; }

        public int filmId { get; set; }
        public virtual Film film { get; set; }

        public int musteriId { get; set; }
        public virtual Musteri musteri { get; set; }
    }
}
