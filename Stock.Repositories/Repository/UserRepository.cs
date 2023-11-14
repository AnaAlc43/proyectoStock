using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Stock.BusinessRules.PersonalException;
using Stock.Repositories.Context;
using Stock.COMMON.Entities;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly Controlstock1Context _context;

        public UserRepository(Controlstock1Context context)
        {
            _context = context;
        }

        public async Task Create(Users user)
        {
            try
            {
                await _context.AddAsync(user);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public Task CreateRol(Roles nombre)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int userId)
        {
            try
            {
                var result = await _context.Users.FirstOrDefaultAsync(a => a.IdUser == userId && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }


        /*public async Task<List<User>> GetAllUsers()
        {
            try
            {
                List<User> result = new List<User>();
                result = await _context.Users.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }*/

        /*public async Task<User> GetById(int userId)
        {
            try
            {
                User result = new User();
                result = await _context.Users.FirstOrDefaultAsync(a => a.Id == userId && a.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }*/

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(Users user)
        {
            throw new NotImplementedException();
        }
        public Task<Users> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task IsDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
