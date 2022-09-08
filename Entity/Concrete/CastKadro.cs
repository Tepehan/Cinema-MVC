using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CastKadro
    {
        [Key]
        public int castKadroId { get; set; }

        [StringLength(20)]
        public string unvan { get; set; }

        [StringLength(20)]
        public string ad{ get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(61)]
        public string aciklama { get; set; }

        public bool durum { get; set; }

        //filmler ile ilişikilednirilicek!!!

        public ICollection<FilmCastKadro> filmCastKadros { get; set; }
    }
}
