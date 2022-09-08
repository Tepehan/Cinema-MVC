using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Salon
    {
        [Key]
        public int salonId { get; set; }

        [StringLength(20)]
        public string salonAd { get; set; }

        [StringLength(20)]
        public string konum { get; set; }
        public short kapasite { get; set; }

        [StringLength(20)]
        public string destekledigiTeknoloji { get; set; }
        public bool durum { get; set; }

        public ICollection<SalonFilm> salonFilms { get; set; }

        //salonfilmler(seanlar) ile ilişkilendirilecek!!!


    }
}
