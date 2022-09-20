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

        public void addBL(Salon salon)
        {
            _salonDal.Insert(salon);
        }

        public Salon getById(int id)
        {
            return _salonDal.GetBy(x => x.salonId == id);
        }

        public List<Salon> list()
        {
            return _salonDal.List();
        }

        public void update(Salon salon)
        {
            _salonDal.Update(salon);
        }
        public void DeleteBL(Salon salon)
        {
            _salonDal.Delete(salon);
        }
    }
}
