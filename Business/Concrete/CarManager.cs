using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
       ICarDal _carDal;
       
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                //eğer ki iş kodlarından geçerse,
                _carDal.Add(car);//DataAccess katmanına bağlanacağız.
                return new SuccessResult("eklendi");
            }
            else
            {
                return new ErrorResult("Tekrar deneyin");
            }

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Güncellendi");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByCarId(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == carId));
        }

       
    }
}
