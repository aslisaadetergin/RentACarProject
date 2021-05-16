using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

            // BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            // brandManager.Add(new Brand
            //{
            //     BrandId=2,
            //     BrandName= "Audi"
            // });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarDescription + "/" + car.BrandName);
            }


            //carManager.Add(new Car
            //{
            //    Id = 2,
            //    BrandId = 10,
            //    ColorId = "8",
            //    ModelYear = "2019",
            //    DailyPrice = "125",
            //    Description = "2019 model bir araba"
            //});
        }
    }
}
