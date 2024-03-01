using JWTRepeat.Domain.DataTransferObjects;
using JWTRepeat.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JWTRepeat.Application.Services.UserServices
{
    public interface IUserService
    {
        public Task<User> Create(User user);
        public Task<User> GetByAny(Expression<Func<User, bool>> expression);
        public Task<IEnumerable<User>> GetAll();
        public Task<bool> Delete(Expression<Func<User, bool>> expression);
        public Task<User> Update(int Id, UserDTO userDTO);
    }
}
