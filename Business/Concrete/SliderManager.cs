using DataAccesLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SliderManager
    {
        ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public List<Slider> list()
        {
            return _sliderDal.List();
        }
    }
}
