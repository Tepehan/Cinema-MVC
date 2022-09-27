using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IAdminService
    {
        void AddAdminBl(Admin admin);
        void UpdateAdminBl(Admin admin);
        void DeleteAdminBl(Admin admin);
        List<Admin> Get();
        Admin GetById(int id);

        Admin GetBy(string userName, string password);

    }
}
