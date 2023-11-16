using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Controllers.UserControllers
{
    public class CreateUserController : ICreateUserController
    {
        readonly ICreateUserInputPort _inputPort;
        readonly ICreateUserPresenter _presenter;

        public CreateUserController(ICreateUserInputPort inputPort, ICreateUserPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WCreateDeleteUser> CreateUser(CreateUserRequest request)
        {
            await _inputPort.Handle(request);
            return _presenter.User;

            //return new UserCreationResult
            //{
            //   Message = $"Usuario '{request.Nombre}' creado con éxito."
            //};
            
        }
    }
}
