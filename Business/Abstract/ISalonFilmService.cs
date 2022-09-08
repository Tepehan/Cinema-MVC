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

        SalonFilm getById(int id);
        void update(SalonFilm sf);
    }
}
