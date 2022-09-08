using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }

        [StringLength(20)]
        public string adminAdi { get; set; }

        [StringLength(20)]
        public string adminSoyadi { get; set; }

        [StringLength(40)]
        public string kullaniciAd { get; set; }

        [StringLength(16)]
        public string sifre { get; set; }
        public string rol { get; set; }
    }
}
