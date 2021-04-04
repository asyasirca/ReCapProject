using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByCarId(int carId);
        IDataResult Add(Rental rental);
        IDataResult Delete(Rental rental);
        IDataResult Update(Rental rental);
    }
}
