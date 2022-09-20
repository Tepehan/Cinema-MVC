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
    public class CastManager:ICastService
    {
        ICastKadroDal _castKadroDal;
        public CastManager(ICastKadroDal castKadroDal)
        {
            _castKadroDal = castKadroDal;
        }
        public void addBL(CastKadro castKadro)
        {
            _castKadroDal.Insert(castKadro);
        }

        public CastKadro getById(int id)
        {
            return _castKadroDal.GetBy(x => x.castKadroId == id);
        }

        public List<CastKadro> list()
        {
            return _castKadroDal.List();
        }

        public void update(CastKadro castKadro)
        {
            _castKadroDal.Update(castKadro);
        }
    }
}
