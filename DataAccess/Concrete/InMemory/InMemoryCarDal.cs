using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice="15", ModelYear="2019", Description="2019 model siyah bmv"},
                new Car{Id=2, BrandId=2, ColorId=1, DailyPrice="20", ModelYear="2018", Description="2018 model siyah wolswogen"},
                new Car{Id=3, BrandId=2, ColorId=2, DailyPrice="25", ModelYear="2019", Description="2019 model beyaz wolswogen"},
                new Car{Id=4, BrandId=5, ColorId=1, DailyPrice="10", ModelYear="2016", Description="2016 model siyah citroen"},
                new Car{Id=5, BrandId=7, ColorId=1, DailyPrice="50", ModelYear="2015", Description="2015 model siyah mercedes"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
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

        public List<Car> GetById()
        {
           //Tekrar düzenleme yapılacaktır
            return _cars;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
