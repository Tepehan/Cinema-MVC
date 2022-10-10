using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SalonFilm
    {
        [Key]
        public int salonFilmlerId { get; set; }

        [StringLength(20)]
        public string gosterimSaat { get; set; }

        [StringLength(20)]
        public string gosterimTarih { get; set; }

        [StringLength(20)]
        public string gosterimGun { get; set; }
        public bool durum { get; set; }

        public int salonId { get; set; }
        public virtual Salon salon { get; set; }

        public int filmId { get; set; }
        public virtual Film film { get; set; }

        public ICollection<SalonFilmMusteri> salonFilmMusteris { get; set; }
    }
}
//musteriler ile ilişki
//yorum