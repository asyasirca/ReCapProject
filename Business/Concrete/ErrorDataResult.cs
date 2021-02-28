using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal class ErrorDataResult : IDataResult<List<Car>>
    {
        public List<Car> Data => throw new System.NotImplementedException();

        public bool Success => throw new System.NotImplementedException();

        public string Message => throw new System.NotImplementedException();
    }
}