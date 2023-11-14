using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.PersonalException;
using Stock.BusinessRules.Wrappers.User;
using Stock.COMMON.Entities;
using Stock.COMMON.Interfaces.Repositories;
using static Stock.BusinessRules.Wrappers.User.WSelectAllUsers;

namespace Stock.UseCases.UsesCases.UserUsesCase
{
    public class GetAllUsersIterator : IGetAllUsersInputPort
    {
        private readonly IUserRepository _repository;
        private readonly IGetAllUsersPresenter _presenter;

        public GetAllUsersIterator(IUserRepository repository, IGetAllUsersPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            WSelectAllUsers usersResponse = new();
            try
            {
                var existingUsers = await _repository.GetAllUsers();

                if (existingUsers != null && existingUsers.Count > 0)
                {
                    foreach (var user in existingUsers)
                    {
                       usersResponse.Users.Add(new User
                       {
                           IdUser = user.Id,
                           NombreUser = user.Nombre
                       });
                    }
                }
                else
                {
                    usersResponse.ErrorNumber = 404;
                    usersResponse.Message = "No existen registros en la tabla Usuarios.";
                }

            }
            catch (DBMySqlException ex)
            {
                usersResponse.ErrorNumber = ex.Number;
                usersResponse.Message = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(usersResponse);
            }
        }
    }
}
