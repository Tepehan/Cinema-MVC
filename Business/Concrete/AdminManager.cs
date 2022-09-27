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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddAdminBl(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public List<Admin> admins()
        {
            return _adminDal.List();
        }

        public void DeleteAdminBl(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public List<Admin> Get()
        {
            throw new NotImplementedException();
        }

        public Admin GetBy(string userName, string password)
        {
           return _adminDal.GetBy(x=>x.kullaniciAd==userName && x.sifre == password);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetBy(x => x.adminId == id);
        }

        public void UpdateAdminBl(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}