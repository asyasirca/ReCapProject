using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(EfCarDal efCarDal)
        {
            EfCarDal = efCarDal;
        }

        public CarManager(ICarDal carDal, BrandManager brandManager)
        {
            _carDal = carDal;
        }

        public EfCarDal EfCarDal { get; }

        public IDataResult Add(Car car)
        {
            if (car.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodlarını yaz
            if (DateTime.Now.Hour == 22)
            {

                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }


            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }


        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.CarsListed);

        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max), Messages.DailyPriceListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == carId), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.CarsListed);
        }

        public IDataResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
