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
    public class TurManager : ITurService
    {
        ITurDal _turDal;
        public TurManager(ITurDal turDal) // Ctor metodu ile Dependency Injection
        {
            _turDal = turDal;
        }
        public void AddBL(Tur tur)
        {
            _turDal.Insert(tur);
        }

        public void DeleteBL(Tur tur)
        {
            _turDal.Delete(tur);
        }

        public Tur getTurById(int id)
        {
           return _turDal.GetBy(x=>x.turId==id);
        }

        public List<Tur> ListBL()
        {
            return _turDal.List();
        }

        public void UpdateBL(Tur tur)
        {
            _turDal.Update(tur);
        }
    }
}
