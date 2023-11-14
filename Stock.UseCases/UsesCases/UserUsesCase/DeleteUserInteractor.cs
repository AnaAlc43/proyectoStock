using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.PersonalException;
using Stock.BusinessRules.Wrappers.User;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.UseCases.UsesCases.UserUseCase
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
