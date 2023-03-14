using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Update(User user);
        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByEmail(string email);
        IDataResult<User> GetCurrentUser();

    }
}
