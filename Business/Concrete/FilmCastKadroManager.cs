using Business.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmCastKadroManager : IFilmCastKadroService
    {
        IFilmCastKadroDal _filmCastKadroDal;
        public FilmCastKadroManager(IFilmCastKadroDal filmCastKadroDal)
        {
            _filmCastKadroDal = filmCastKadroDal;
        }

        public void addBL(FilmCastKadro filmCastKadro)
        {
            _filmCastKadroDal.Insert(filmCastKadro);
        }

        public void DeleteBL(FilmCastKadro filmCastKadro)
        {
            _filmCastKadroDal.Delete(filmCastKadro);
        }

        public FilmCastKadro getById(int id)
        {
            return _filmCastKadroDal.GetBy(x => x.filmlerCastKadroId == id);
        }

        public List<FilmCastKadro> list()
        {
            return _filmCastKadroDal.List();
        }

        public void update(FilmCastKadro filmCastKadro)
        {
            _filmCastKadroDal.Update(filmCastKadro);
        }
    }
}
