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

        public Musteri GetBy(string userName, string password)
        {
            return _musteriDal.GetBy(x => x.ad == userName && x.sifre == password);
        }

        public void UpdateMusteri(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }
    }
}
