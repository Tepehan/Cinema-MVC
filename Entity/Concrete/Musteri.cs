using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Musteri
    {
        [Key]
        public int musteriId { get; set; }

        [StringLength(20)]
        public string ad { get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(20)]
        public string sifre { get; set; }

        [StringLength(2)]
        public string gun { get; set; }

        [StringLength(2)]
        public string ay { get; set; }

        [StringLength(4)]
        public string yil { get; set; }

        [StringLength(30)]
        public string eMail { get; set; }

        [StringLength(20)]
        public string telefonNumara { get; set; }

        [StringLength(11)]
        public string tc { get; set; }
        public bool cinsiyet { get; set; }
        public bool durum { get; set; }
        //salonfimler(seanslar) ile ilişkilendirilecek!!!

        public ICollection<SalonFilmMusteri> salonFilmMusteris { get; set; }

        //yorum ile ilişkilendiridi
        public ICollection<Yorum>yorums { get; set; }

    }
}

