using MySql.Data.MySqlClient


namespace Stock.Repository.Repositories
{
    public class ActorRepository : IUserRepository
    {
        readonly StockContext _context;

        public ActorRepository(VideoClubContext context)
        {
            _context = context;
        }

        public async Task Create(User user)
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

        public async Task Delete(int userId)
        {
            try
            {
                var result = await _context.Users.FirstOrDefaultAsync(a => a.Id == userId && a.IsDeleted == false);
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

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                List<User> result = new List<User>();
                result = await _context.Actors.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<User> GetById(int userId)
        {
            try
            {
                User result = new User();
                result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == userId && a.IsDeleted == false);
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

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
