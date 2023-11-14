using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.BusinessRules.Interfaces.Getways.UserGetways.InputPorts;
using Stock.BusinessRules.Interfaces.Presenters.UserPresenters;
using Stock.BusinessRules.Wrappers.User;

namespace Stock.Controllers.UserControllers
{
    public class GetUserByIdController : IGetUserByIdController
    {
        readonly IGetUserByIdInputPort _inputPort;
        readonly IGetUserByIdPresenter _presenter;

        public GetUserByIdController(IGetUserByIdInputPort inputPort, IGetUserByIdPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        async Task<WSelectUser> IGetUserByIdController.GetUser(int IdUser)
        {
            await _inputPort.Handle(IdUser);
            return _presenter.User;
        }
    }
}