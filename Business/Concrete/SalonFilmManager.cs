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

        public SalonFilm getById(int id)
        {
            return salonFilmDal.GetById(x=>x.salonFilmlerId==id);
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
