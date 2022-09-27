using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuService
    {
        void AddBL(Menu menu);
        void UpdateBL(Menu menu);
        void DeleteBL(Menu menu);
        List<Menu> ListBL();
        Menu GetByIdBL(int id);

    }
}