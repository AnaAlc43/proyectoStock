using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.PersonalException;
using Stock.BusinessRules.Wrappers.User;
using Stock.COMMON.Entities;
using Stock.COMMON.Interfaces.Repositories;
using Stock.BusinessRules.DTOs.UserDTOs;



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
            WSelectAllUsers userResponse = new();
            try
            {
                var existingUsers = await _repository.GetAllUsers();

                if (existingUsers != null && existingUsers.Count > 0)
                {
                    foreach (var user in existingUsers)
                    {
                       userResponse.Users.Add(new UserResponse
                       {
                           Id = user.Id,
                           NombreUsuario = user.Nombre
                       });
                    }
                }
                else
                {
                    userResponse.ErrorNumber = 404;
                    userResponse.Message = "No existen registros en la tabla Usuarios.";
                }

            }
            catch (DBMySqlException ex)
            {
                userResponse.ErrorNumber = ex.Number;
                userResponse.Message = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(userResponse);
            }
        }
    }
}
