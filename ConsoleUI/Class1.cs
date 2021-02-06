using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Class1
    {
        static void Main(string[] args)
        {
           
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka ID : " + car.BrandId + " Model : " + car.ModelYear + " Fiyat : " + car.DailyPrice + " Açıklama : " + car.Description);
            }


        }
    }
}

