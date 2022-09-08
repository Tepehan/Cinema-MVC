using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class FilmCastKadro
    {
        [Key]
        public int filmlerCastKadroId { get; set; }
        public bool durum { get; set; }

        [StringLength(20)]
        public string tarih { get; set; }


        public int castKadroId { get; set; }
        public virtual CastKadro castKadro { get; set; }


        public int filmId { get; set; }
        public virtual Film film { get; set; }



        //filmler ile
        //castkadro ile        
    }
}