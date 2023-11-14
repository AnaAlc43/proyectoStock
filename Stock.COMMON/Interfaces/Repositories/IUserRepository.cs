using System.Collections.Generic;
using System.Threading.Tasks;
using Stock.COMMON.Entities;


namespace Stock.COMMON.Interfaces.Repositories
{
    public interface IUserRepository : IUnitOfWork
    {

        Task<Users> GetById(int id);
        Task Create(Users user);
        Task CreateRol(Roles nombre);
        Task Update(Users user);
        Task Delete(int userid);
        Task<List<Users>> GetAllUsers();
        //Task<List<Actor>> GetAllActorsByName(string name);

    }
}