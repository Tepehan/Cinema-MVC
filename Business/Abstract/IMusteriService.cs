using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        void AddMusteri(Musteri musteri);
        void UpdateMusteri(Musteri musteri);
        void DeleteMusteri(Musteri musteri);
        List<Musteri> Get();
        Musteri GetBy(string userName, string password);

    }
}
