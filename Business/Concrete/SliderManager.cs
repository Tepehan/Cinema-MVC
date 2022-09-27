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
    public class SliderManager
    {
        ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public List<Slider> listBL()
        {
            return _sliderDal.List();
        }

        public void Add(Slider slider)
        {
            _sliderDal.Insert(slider);
        }

        public Slider getById(int id)
        {
            return _sliderDal.GetBy(x => x.sliderId == id);
        }

        public void update(Slider slider)
        {
            _sliderDal.Update(slider);
        }
        public void Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
        }
    }
}
