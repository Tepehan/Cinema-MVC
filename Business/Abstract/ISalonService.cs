using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISalonService
    {
        List<Salon> list();
       
        void addBL(Salon salon);

        Salon getById(int id);
        void update(Salon salon);
        void DeleteBL(Salon salon);
    }
}
