using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SalonFilmMusteri
    {
        [Key]
        public int salonFilmMusteriId { get; set; }
        public DateTime biletKesimTarih { get; set; }

        [StringLength(20)]
        public string koltukNo { get; set; }
        public bool durum { get; set; }

        //musteriler ile ilişkilendirilecek!!!
        //SAlonfilm(seanlar)ile ilişkilendirilecek!!!

        public int musteriId { get; set; }
        public virtual Musteri musteri { get; set; }

        public int salonId { get; set; }
        public virtual Salon salon { get; set; }

    }
}
