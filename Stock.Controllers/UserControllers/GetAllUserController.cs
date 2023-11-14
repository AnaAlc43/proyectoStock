using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Controllers.UserControllers
{
    public class GetAllUserController : IGetAllUserController
    {
        readonly IGetAllUsersInputPort _inputPort;
        readonly IGetAllUsersPresenter _presenter;

        public GetAllUserController(IGetAllUsersInputPort inputPort, IGetAllUsersPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<WSelectAllUsers> GetUsers()
        {
            await _inputPort.Handle();
            return _presenter.Users;
        }
    }
}
