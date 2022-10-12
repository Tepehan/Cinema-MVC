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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public MusteriManager(EfMusteriDal efMusteriDal)
        {
            EfMusteriDal = efMusteriDal;
        }

        public EfMusteriDal EfMusteriDal { get; }

        public void AddMusteri(Musteri musteri)
        {
            _musteriDal.Insert(musteri);
        }

        public void DeleteMusteri(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
        }

        public List<Musteri> Get()
        {
            return _musteriDal.List();
        }

        public void UpdateMusteri(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }
    }
}
