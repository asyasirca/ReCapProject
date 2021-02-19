﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id); //yine bir ürün listesi ama filtrelenmiş ürün listesi
        
        List<Car> GetCarsByColorId(int id);
        bool Add(Car car);
    }
}
