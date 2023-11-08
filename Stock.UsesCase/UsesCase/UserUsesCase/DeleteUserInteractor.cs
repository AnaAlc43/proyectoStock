using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.PersonalException;
using Stock.BusinessRules.Wrappers.User;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.UseCases.UseCases.UserUseCase
{
    public class DeleteUserInteractor : IDeleteUserInputPort
    {
        private readonly IUserRepository _repository;
        private readonly IDeleteUserPresenter _presenter;

        public DeleteUserInteractor(IUserRepository repository, IDeleteUserPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idUser)
        {

            WDeleteUser userResponse = new();
            try
            {
                // Obtener el userResponse existente por su ID
                //var existingUser = _repository.GetById(idUser);

                //if (existingUser == null)
                //{
                //    // Manejar el caso en el que el userResponse no existe
                //    // Devuelve un mensaje indicando que el userResponse no se encontró.
                //    userResponse.ErrorNumber = 404;
                //    userResponse.Message = "El Id proporcionado no es valido o no existe";
                //    await _presenter.Handle(userResponse);
                //    return;
                //}

                // Eliminar el usuario
                await _repository.Delete(idUser);
                await _repository.SaveChange();
                userResponse.IdUser = idUser;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                userResponse.ErrorNumber = ex.Number;
                userResponse.Message = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el usuario.
                await _presenter.Handle(userResponse);
            }

        }
    }
}
