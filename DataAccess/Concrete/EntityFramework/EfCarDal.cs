using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapDBContext context= new ReCapDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                return filter == null //filtre null mı ?
                    ? context.Set<Car>().ToList() //null ise filtre yoksa ürünleri listele ver
                    : context.Set<Car>().Where(filter).ToList(); //null degil ise filtreleyip listele ver.
            }
        }

        public List<Car> GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
