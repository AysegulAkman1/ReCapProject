using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()//constructor
        {
            _cars = new List<Car> {

                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=90,ModelYear=2018,Description="Otomatik Dizel"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=160,ModelYear=2019,Description="Otomatik Hibrit"},
                new Car{Id=3,BrandId=1,ColorId=1,DailyPrice=70,ModelYear=2012,Description="Manuel Benzinli"},
                new Car{Id=4,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=2016,Description="Otomatik Dizel"},
                new Car{Id=5,BrandId=1,ColorId=1,DailyPrice=120,ModelYear=2019,Description="Otomatik Benzinli"}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(DeleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

       

        public void Update(Car car)
        {
            Car UpdateToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            UpdateToCar.Id = car.Id;
            UpdateToCar.BrandId = car.BrandId;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.DailyPrice = car.DailyPrice;
            UpdateToCar.Description = car.Description;
            UpdateToCar.ModelYear = car.ModelYear;

        }
    }
}
