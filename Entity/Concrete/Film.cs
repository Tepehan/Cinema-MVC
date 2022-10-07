using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Film
    {
        [Key]
        public int filmId { get; set; }

        [StringLength(20)]
        public string filmIsim { get; set; }

        [StringLength(400)]
        public string ozet { get; set; }

        [StringLength(13)]
        public string dil { get; set; }
        public short sure { get; set; }
        public DateTime? vizyonTarihi { get; set; }

        [StringLength(50)]
        public string destekledigiTeknolojiler { get; set; }

        public double butce { get; set; }

        [StringLength(250)]
        public string afisUrl { get; set; }

        public bool durum { get; set; }

        [StringLength(200)]
        public string seoUrl { get; set; }

        //turler ile ilişkilendirilecek!!!
        //salonfilmler ile ilişkilendirilecek(seanslar)!!!
        //castKadro ile ilişkilendirilecek!!!

        public int turId { get; set; }

        public virtual Tur tur { get; set; }  //tur tablosuyla ilişkilendirme

        public ICollection<FilmCastKadro> filmCastKadros { get; set; }

        public ICollection<SalonFilm> salonFilms { get; set; }

        //yorum ile ilişkilendiridi
        public ICollection<Yorum> yorums { get; set; }




    }
}
