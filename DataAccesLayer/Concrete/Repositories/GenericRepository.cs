using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccesLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepositoryDal<T> where T:class  //kısıtlama koyduk
    {
        

        Context context = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T p)
        {
            var deletedItem = context.Entry(p);
            deletedItem.State = EntityState.Deleted;
            // _object.Remove(p);
            context.SaveChanges();
        }

        public T GetBy(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedItem = context.Entry(p);
            addedItem.State = EntityState.Added;

            //_object.Add(p);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedItem = context.Entry(p);
            updatedItem.State = EntityState.Modified;
            context.SaveChanges();
        }
        
    }
}
