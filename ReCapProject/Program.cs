using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();

            // BrandTest();
            // CarDetailDtoTest();

            UserTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }



        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }
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

        private static void CarDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
