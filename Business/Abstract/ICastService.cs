using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICastService
    {
        List<CastKadro> list();
        void addBL(CastKadro castKadro);

        CastKadro getById(int id);
        void update(CastKadro castKadro);
    }
}
