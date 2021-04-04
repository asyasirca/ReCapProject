using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCustomerDal : ICustomerDal
    {
        List<Customer> _customer;
        public InMemoryCustomerDal()
        {
            _customer = new List<Customer>
            {

                new Customer {UserId = 1,CustomerId = 1,CustomerCompanyName = "Atacan A.Ş"},
                new Customer {UserId = 2,CustomerId = 3,CustomerCompanyName = "Zirve A.Ş"},
                new Customer {UserId = 1,CustomerId = 2,CustomerCompanyName = "Pinhan Oto"}





            };

        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
