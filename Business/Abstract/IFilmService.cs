using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFilmService
    {
        void AddBL(Film film);
        void UpdateBL(Film film);
        void DeleteBL(Film film);
        List<Film> ListBL();
        List<Film> GetListByTurBL(int id);
       Film GetByIdBL(int id);
        
       
    }
}
