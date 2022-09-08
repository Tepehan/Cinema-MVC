using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace Entity.Concrete.Modals
{
    public class TurFilmModal
    {
        public IEnumerable<Tur> turModal { get; set; }
        public IEnumerable<Film> filmModal { get; set; }
    }
}
