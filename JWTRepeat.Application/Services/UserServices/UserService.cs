﻿using JWTRepeat.Domain.DataTransferObjects;
using JWTRepeat.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JWTRepeat.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(int Id, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
