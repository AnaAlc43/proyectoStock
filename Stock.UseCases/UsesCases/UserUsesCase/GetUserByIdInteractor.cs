using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.Wrappers.User;
using Stock.COMMON.Interfaces.Repositories;

namespace Stock.UseCases.UsesCases.UserUseCase
{
    public class GetUserByIdInteractor : IGetUserByIdInputPort
    {
        private readonly IUserRepository _repository;
        private readonly IGetUserByIdPresenter _presenter;

        public GetUserByIdInteractor(IUserRepository repository, IGetUserByIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int idUser)
        {
            WSelectUser userResponse = new();

            try
            {
                var existingUser = await _repository.GetById(idUser);
                if (existingUser != null)
                {
                    userResponse.IdUser = existingUser.Id;
                    userResponse.NombreUser = existingUser.Nombre;
                }
                else
                {
                    userResponse.ErrorNumber = 404;
                    userResponse.Message = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                userResponse.Message = ex.Message;

            }
            finally
            {
                await _presenter.Handle(userResponse);
            }
        }
    }
}
