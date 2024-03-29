﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = br.BrandName,
                                 CarDescription = c.Description,
                                 ColorName = co.ColorName
                             };
                return result.ToList();
            }
        }
    }
}