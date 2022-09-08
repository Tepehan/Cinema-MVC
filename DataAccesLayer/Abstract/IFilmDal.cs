
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IFilmDal:IRepositoryDal<Film> //delete,update,insert işlemi yapacak bir interface tanımladık.
    {
      
    }
}
