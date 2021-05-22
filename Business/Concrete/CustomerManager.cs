using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _ıcustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _ıcustomerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _ıcustomerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _ıcustomerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_ıcustomerDal.GetAll(), Messages.CustomerListed);
        }



        public IResult Update(Customer customer)
        {
            _ıcustomerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
