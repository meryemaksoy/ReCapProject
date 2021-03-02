﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
              new Car{CarId=1, BrandId=1, ColorId=2, DailyPrice=100, Description="fıat", ModelYear=2020},
              new Car{CarId=2, BrandId=2, ColorId=1, DailyPrice=200, Description="toyota", ModelYear=2021},
              new Car{CarId=3, BrandId=3, ColorId=2, DailyPrice=300, Description="passat", ModelYear=2019},
              new Car{CarId=4, BrandId=4, ColorId=1, DailyPrice=150, Description="hyundai", ModelYear=2018},
              new Car{CarId=5, BrandId=5, ColorId=3, DailyPrice=250, Description="honda", ModelYear=2017},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
          return  _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
