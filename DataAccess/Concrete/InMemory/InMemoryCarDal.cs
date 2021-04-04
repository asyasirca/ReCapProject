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
            _cars = new List<Car> {

                new Car { CarId = 1, BrandId = 1, ColorId = 2, BrandName = "Mercedes", DailyPrice = 800, ModelYear = 2015, Description = "Dizel,otomatik vites"},
                new Car { CarId = 2, BrandId = 1, ColorId = 1, BrandName = "Mercedes", DailyPrice = 1000, ModelYear = 2018, Description = "Dizel,manuel vites" },
                new Car { CarId = 3, BrandId = 2, ColorId = 3, BrandName = "Renault", DailyPrice = 600, ModelYear = 2015, Description = "Dizel,otomatik vites" },
                new Car { CarId = 4, BrandId = 3, ColorId = 1, BrandName = "Fiat", DailyPrice = 500, ModelYear = 2017, Description = "Otogaz,manuel vites" },
                new Car { CarId = 5, BrandId = 1, ColorId = 3, BrandName = "Mercedes", DailyPrice = 1100, ModelYear = 2018, Description = "Dizel,manuel vites" }



            };



        }

        public void Add(Car car)//yeni ürünü buradan ekleriz
        {
            _cars.Add(car);
        }

        public void Delete(Car car)//ürün sileriz
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);//linq ile..singleordefault id ile aramalarda kullanılır

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()//veritabaındaki datayı busines a vermek lazım.business ürün listesi istediğinde ona liste vermek zorundayız
        {
            return _cars;//veri tabanının tümünü döndürür
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandName(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
            //where koşulu içindeki şarta uyan tüm elemanları yeni bir liste haline getirir
            //ve onu döndürür.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            //gönderdiğim ürün id sine sahip olan listedeki  ürünü bul demek
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;//gibi gibi

        }
    }
}
