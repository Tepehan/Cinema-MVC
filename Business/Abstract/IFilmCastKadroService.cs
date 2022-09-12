using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFilmCastKadroService
    {
        List<FilmCastKadro> list();

        void addBL(FilmCastKadro filmCastKadro);

        FilmCastKadro getById(int id);
        void update(FilmCastKadro filmCastKadro);
        void DeleteBL(FilmCastKadro filmCastKadro);
    }
}
