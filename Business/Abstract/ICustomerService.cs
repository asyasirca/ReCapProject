using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult Add(Customer customer);
        IDataResult Delete(Customer customer);
        IDataResult Update(Customer customer);
    }
}
