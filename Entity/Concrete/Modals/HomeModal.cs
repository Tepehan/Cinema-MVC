using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Modals
{
   public class HomeModal
    {
        public IEnumerable<Slider> sliderModal { get; set; }
        public IEnumerable<Film> filmModal { get; set; }
        public IEnumerable<Menu> menuModal { get; set; }


    }
}
