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
   public class SalonManager : ISalonService
    {
        ISalonDal _salonDal;

        public SalonManager(ISalonDal salonDal)
        {
            _salonDal = salonDal;
        }

        public List<Salon> list()
        {
           return _salonDal.List();
        }
    }
}
