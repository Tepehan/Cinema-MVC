using Business.Abstract;
using DataAccesLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SalonFilmManager : ISalonFilmService
    {
        ISalonFilmDal salonFilmDal;

        public SalonFilmManager(ISalonFilmDal salonFilmDal)
        {
            this.salonFilmDal = salonFilmDal;
        }

        public void addBL(SalonFilm salonFilm)
        {
            salonFilmDal.Insert(salonFilm);
        }

        public SalonFilm getBySalonFilmId(int id)
        {
            return salonFilmDal.GetBy(x=>x.salonFilmlerId==id);
        }

        public List<SalonFilm> getSeansBySeoUrl(string seoUrl)
        {
            return salonFilmDal.List(x=>x.film.seoUrl== seoUrl);
        }
        public List<SalonFilm> getSeansByFilmId(int filmId)
        {
            return salonFilmDal.List(x => x.film.filmId == filmId);
        }

        public List<SalonFilm> list()
        {
           return salonFilmDal.List();
        }

        public void update(SalonFilm sf)
        {
            salonFilmDal.Update(sf);
        }
    }
}
