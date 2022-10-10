using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISalonFilmService 
    {
        List<SalonFilm> list();
        void addBL(SalonFilm salonFilm);
        void update(SalonFilm sf);
        SalonFilm getBySalonFilmId(int id);
        List<SalonFilm> getSeansBySeoUrl(string seoUrl);
        List<SalonFilm> getSeansByFilmId(int filmId);
    }
}
