using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Modals
{
    public class SalonFilmModal
    {
        public IEnumerable<Salon> salonModal { get; set; }
        public IEnumerable<Film> filmModal { get; set; }
        public SalonFilm salonFilmModal { get; set; }

    }
}
