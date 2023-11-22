using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.User;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Controllers.UserControllers
{
    public class DeleteUserController : IDeleteUserController
    {
        readonly IDeleteUserInputPort _inputPort;
        readonly IDeleteUserPresenter _presenter;

        public DeleteUserController(IDeleteUserInputPort inputPort, IDeleteUserPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WDeleteUser> DeleteUser(int IdUser)
        {
            await _inputPort.Handle(IdUser);
            return _presenter.User;
        }
    }
}