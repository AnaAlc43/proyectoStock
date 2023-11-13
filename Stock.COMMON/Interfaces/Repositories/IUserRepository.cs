using System.Collections.Generic;
using System.Threading.Tasks;
using Stock.COMMON.Entities;


namespace Stock.COMMON.Interfaces.Repositories
{
    public interface IUserRepository : IUnitOfWork
    {

        Task<User> GetById(int id);
        Task Create(User user);
        Task CreateRol(Roles nombre);
        Task Update(User user);
        Task Delete(int userid);
        Task<List<User>> GetAllUsers();
        //Task<List<Actor>> GetAllActorsByName(string name);

    }
}