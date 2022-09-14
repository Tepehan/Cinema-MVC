using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
    public class EfSliderDal : GenericRepository<Slider>, ISliderDal
    {
    }
}
