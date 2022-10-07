using Business.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmManagerBL : IFilmService
    {
        IFilmDal _filmDal;

        public FilmManagerBL(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public void AddBL(Film film)
        {
            _filmDal.Insert(film);
        }

        public void DeleteBL(Film film)
        {
            _filmDal.Delete(film);
        }

        public Film GetByIdBL(int id)
        {
            return _filmDal.GetBy(x => x.filmId == id);
        }

        public Film GetBySeoBl(string seo)
        {
            return _filmDal.GetBy(x => x.seoUrl == seo);
        }

        public List<Film> GetListByFilmBL(string filmAdi)
        {
            return _filmDal.List(x => x.filmIsim.Contains(filmAdi));
        }

        public List<Film> GetListByTurBL(int id)
        {
            return _filmDal.List(x => x.turId == id);
        }

        public List<Film> ListBL()
        {
            return _filmDal.List();
        }

        public void UpdateBL(Film film)
        {
            _filmDal.Update(film);
        }
    }
}
