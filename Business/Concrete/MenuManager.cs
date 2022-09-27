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
    public class MenuManager : IMenuService
    {

        IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void AddBL(Menu menu)
        {
            _menuDal.Insert(menu);
        }
        public void DeleteBL(Menu menu)
        {
            _menuDal.Delete(menu);
        }
        public void UpdateBL(Menu menu)
        {
            _menuDal.Update(menu);
        }
        public Menu GetByIdBL(int id)
        {
            return _menuDal.GetBy(x => x.menuId == id);
        }
        public List<Menu> ListBL()
        {
            return _menuDal.List();
        }

    }
}
