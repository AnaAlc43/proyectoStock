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
                await _context.Users.AddAsync(user);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int userId)
        {
            try
            {
                var result = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId && u.IsDeleted == false);
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

        public Task CreateRol(Roles nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Users>> GetAllUsers()
        {
            try
            {
                List<Users> result = new();
                result = await _context.Users.Where(u => u.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<Users> GetById(int userId)
        {
            try
            {
                Users result = new();
                result = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId && u.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
