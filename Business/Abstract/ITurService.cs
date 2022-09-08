using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITurService
    {
        void AddBL(Tur tur);
        void UpdateBL(Tur tur);
        void DeleteBL(Tur tur);
        List<Tur> ListBL();
        Tur getTurById(int id);

    }
}
