using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entities.Entities;

namespace Stock.Entities.Interfaces.Repositories
{
    public interface IUserRepository : IUnitOfWork
    {
        Task<User> GetById(int id);
        Task Create(User user);
        Task CreateRol(UserRoles nombre);
        Task Update(User user);
        Task Delete(int id);
    }
}