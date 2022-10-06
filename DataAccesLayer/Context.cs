using Entity;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class Context:DbContext
    {

        public Context() : base("server=SMPR303-00;database=Dbsinema;uid=sa;password=1234;")
        {
        }

        public DbSet<Film> filmler { get; set; }
        public DbSet<CastKadro> castKadrolar { get; set; }
        public DbSet<FilmCastKadro> filmCastKadrolar { get; set; }
        public DbSet<Musteri> musteriler { get; set; }
        public DbSet<Salon> salonlar { get; set; }
        public DbSet<SalonFilm> salonFilmler { get; set; }
        public DbSet<SalonFilmMusteri> salonFilmMusteri { get; set; }
        public DbSet<Tur> turler { get; set; }
        public DbSet<Admin> adminler { get; set; }
        public DbSet<Slider> sliderlar { get; set; }
        public DbSet<Menu> menuler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here..

        }
    }
}
